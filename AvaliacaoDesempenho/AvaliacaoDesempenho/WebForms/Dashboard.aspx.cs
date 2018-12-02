using ADFramework.Classes;
using AvaliacaoDesempenho.MasterPages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoDesempenho.WebForms
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable user = null;

            try
            {              
                if((DataTable)(Session["User"]) != null)
                {
                    user = (DataTable)(Session["User"]);

                    if (Convert.ToInt32(user.Rows[0][TabUtilizador.Gru_Id]) == 3)
                    {
                        Response.Redirect("/AvaliacaoDesempenho");
                    }
                    else
                    {
                        ((PaginaBase)this.Master).Menu_Dashboard.Attributes.Add("class", "active");
                        _CarregaDados();
                        _CarregaCharts();
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _CarregaDados()
        {
            DataTable TabelaUtilizador = null;
            DataTable TabelaAvaliacao = null;
            DataTable TabelaAvaliacaoAcima = null;

            try
            {

                TabelaUtilizador = TabUtilizador.Metodo.Select(TabUtilizador.Gru_Id + "=" + 3);
                TabelaAvaliacao = TabAvaliacao.Metodo.Select(TabAvaliacao.Id + ">0");
                TabelaAvaliacaoAcima = TabAvaliacao.Metodo.Select(TabAvaliacao.Classificacao_Final + ">50");

                if (TabelaUtilizador.Rows.Count > 0)
                {
                    NumeroUtilizadores.InnerText = TabelaUtilizador.Rows.Count.ToString();
                    UtilAvaliacaoCompleta.InnerText = TabelaAvaliacao.Rows.Count.ToString();
                    UtilAvaliacaoPendente.InnerText = (TabelaUtilizador.Rows.Count - TabelaAvaliacao.Rows.Count).ToString();
                    Acima50.InnerText = TabelaAvaliacaoAcima.Rows.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _CarregaCharts()
        {
            DataTable TabelaAvaliacao = null;

            int Q1Menor25 = 0;
            int Q1Menor50 = 0;
            int Q1Menor75 = 0;
            int Q1Maior75 = 0;

            int Q2Menor25 = 0;
            int Q2Menor50 = 0;
            int Q2Menor75 = 0;
            int Q2Maior75 = 0;

            int Q3Menor3 = 0;
            int Q3Menor5 = 0;
            int Q3Menor8 = 0;
            int Q3Maior8 = 0;

            int Q4Menor3 = 0;
            int Q4Menor5 = 0;
            int Q4Menor8 = 0;
            int Q4Maior8 = 0;

            decimal MediaQ1 = 0;
            decimal MediaQ2 = 0;
            decimal MediaQ3 = 0;
            decimal MediaQ4 = 0;

            string myScript = "";

            try
            {

                TabelaAvaliacao = TabAvaliacao.Metodo.Select(TabAvaliacao.Id + ">0");

                if (TabelaAvaliacao.Rows.Count > 0)
                {
                    for(int i=0; i< TabelaAvaliacao.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Um]) < 25) { Q1Menor25 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Um]) < 50 ) { Q1Menor50 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Um]) < 75) { Q1Menor75 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Um]) > 75) { Q1Maior75 += 1; }

                        if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Dois]) < 25) { Q2Menor25 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Dois]) < 50) { Q2Menor50 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Dois]) < 75) { Q2Menor75 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Dois]) > 75) { Q2Maior75 += 1; }

                        if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Tres]) <= 20) { Q3Menor3 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Tres]) <= 40) { Q3Menor5 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Tres]) <= 60) { Q3Menor8 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Tres]) >= 80) { Q3Maior8 += 1; }

                        if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Quatro]) <= 20) { Q4Menor3 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Quatro]) <= 40) { Q4Menor5 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Quatro]) <= 60) { Q4Menor8 += 1; }
                        else if (Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Quatro]) >= 80) { Q4Maior8 += 1; }

                        MediaQ1 = MediaQ1 + Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Um]);
                        MediaQ2 = MediaQ2 + Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Dois]);
                        MediaQ3 = MediaQ3 + Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Tres]);
                        MediaQ4 = MediaQ4 + Convert.ToInt32(TabelaAvaliacao.Rows[i][TabAvaliacao.Classificacao_Quatro]);
                    }

                    MediaQ1 = decimal.Round(MediaQ1 / TabelaAvaliacao.Rows.Count, 2);
                    MediaQ2 = decimal.Round(MediaQ2 / TabelaAvaliacao.Rows.Count, 2);
                    MediaQ3 = decimal.Round(MediaQ3 / TabelaAvaliacao.Rows.Count, 2);
                    MediaQ4 = decimal.Round(MediaQ4 / TabelaAvaliacao.Rows.Count, 2);

                    myScript += "\n<script type=\"text/javascript\" language=\"Javascript\">\n";
                    myScript += "var piePerformance = [";
                    myScript += "{ value: " + Q1Menor25 + ", color: \"#f9243f\", highlight: \"#f6495f\", label: \"Menor que 25%\" },";
                    myScript += "{ value: " + Q1Menor50 + ", color: \"#ffb53e\", highlight: \"#fac878\", label: \"Menor que 50%\" },";
                    myScript += "{ value: " + Q1Menor75 + ", color: \"#30a5ff\", highlight: \"#62b9fb\", label: \"Menor que 75%\" },";
                    myScript += "{ value: " + Q1Maior75 + ", color: \"#1ebfae\", highlight: \"#3cdfce\", label: \"Maior que 75%\"}";
                    myScript += "];";

                    myScript += "var pieCompetencias = [";
                    myScript += "{ value: " + Q2Menor25 + ", color: \"#f9243f\", highlight: \"#f6495f\", label: \"Menor que 25%\" },";
                    myScript += "{ value: " + Q2Menor50 + ", color: \"#ffb53e\", highlight: \"#fac878\", label: \"Menor que 50%\" },";
                    myScript += "{ value: " + Q2Menor75 + ", color: \"#30a5ff\", highlight: \"#62b9fb\", label: \"Menor que 75%\" },";
                    myScript += "{ value: " + Q2Maior75 + ", color: \"#1ebfae\", highlight: \"#3cdfce\", label: \"Maior que 75%\"}";
                    myScript += "];";

                    myScript += "var pieExpTrabalho = [";
                    myScript += "{ value: " + Q4Menor3 + ", color: \"#f9243f\", highlight: \"#f6495f\", label: \"Menos de 3 anos\" },";
                    myScript += "{ value: " + Q4Menor5 + ", color: \"#ffb53e\", highlight: \"#fac878\", label: \"Menos de 5 anos\" },";
                    myScript += "{ value: " + Q4Menor8 + ", color: \"#30a5ff\", highlight: \"#62b9fb\", label: \"Menos de 8 anos\" },";
                    myScript += "{ value: " + Q4Maior8 + ", color: \"#1ebfae\", highlight: \"#3cdfce\", label: \"Mais de 8 anos\"}";
                    myScript += "];";

                    myScript += "var pieExpPosicao = [";
                    myScript += "{ value: " + Q3Menor3 + ", color: \"#f9243f\", highlight: \"#f6495f\", label: \"Menos de 3 anos\" },";
                    myScript += "{ value: " + Q3Menor5 + ", color: \"#ffb53e\", highlight: \"#fac878\", label: \"Menos de 5 anos\" },";
                    myScript += "{ value: " + Q3Menor8 + ", color: \"#30a5ff\", highlight: \"#62b9fb\", label: \"Menos de 8 anos\" },";
                    myScript += "{ value: " + Q3Maior8 + ", color: \"#1ebfae\", highlight: \"#3cdfce\", label: \"Mais de 8 anos\"}";
                    myScript += "];";



                    myScript += "window.onload = function() {;";

                    myScript += "var chart1 = document.getElementById(\"pie-chart-performance\").getContext(\"2d\");";
                    myScript += "window.myPie = new Chart(chart1).Pie(piePerformance, {";
                    myScript += "responsive: true";
                    myScript += "});";

                    myScript += "var chart2 = document.getElementById(\"pie-chart-competencias\").getContext(\"2d\");";
                    myScript += "window.myPie = new Chart(chart2).Pie(pieCompetencias, {";
                    myScript += "responsive: true";
                    myScript += "});";

                    myScript += "var chart3 = document.getElementById(\"pie-chart-exptrabalho\").getContext(\"2d\");";
                    myScript += "window.myPie = new Chart(chart3).Pie(pieExpTrabalho, {";
                    myScript += "responsive: true";
                    myScript += "});";

                    myScript += "var chart4 = document.getElementById(\"pie-chart-expposicao\").getContext(\"2d\");";
                    myScript += "window.myPie = new Chart(chart4).Pie(pieExpPosicao, {";
                    myScript += "responsive: true";
                    myScript += "});";

                    myScript += "};";
                    myScript += "\n\n </script>";

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "myKey", myScript, false);

                    DivMediaQ1.InnerHtml = "<div class=\"easypiechart\" id=\"easypiechart-blue\" data-percent=\"" + Convert.ToInt32(MediaQ1).ToString() + "\"><span class=\"percent\">" + Convert.ToInt32(MediaQ1).ToString() + "%</span></div>";
                    DivMediaQ2.InnerHtml = "<div class=\"easypiechart\" id=\"easypiechart-orange\" data-percent=\"" + Convert.ToInt32(MediaQ2).ToString() + "\"><span class=\"percent\">" + Convert.ToInt32(MediaQ2).ToString() + "%</span></div>";
                    DivMediaQ3.InnerHtml = "<div class=\"easypiechart\" id=\"easypiechart-teal\" data-percent=\"" + Convert.ToInt32(MediaQ3).ToString() + "\"><span class=\"percent\">" + Convert.ToInt32(MediaQ3).ToString() + "%</span></div>";
                    DivMediaQ4.InnerHtml = "<div class=\"easypiechart\" id=\"easypiechart-red\" data-percent=\"" + Convert.ToInt32(MediaQ4).ToString() + "\"><span class=\"percent\">" + Convert.ToInt32(MediaQ4).ToString() + "%</span></div>";

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}