using ADFramework.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoDesempenho.WebForms
{
    public partial class Funcionarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _CarregaFuncionarios();
        }

        private void _CarregaFuncionarios()
        {
            DataTable Tabela = null;
            string user = "";

            try
            {

                Tabela = TabUtilizador.Metodo.Select(TabUtilizador.Gru_Id + "=3", TabUtilizador.PrimeiroNome + ", " + TabUtilizador.UltimoNome);

                if (Tabela.Rows.Count > 0)
                {
                    for (int i = 0; i < Tabela.Rows.Count; i++)
                    {
                        DataTable TabelaAvaliacao = TabAvaliacao.Metodo.Select(TabAvaliacao.Uti_Id + "=" + Tabela.Rows[i][TabUtilizador.Id]);

                        user += "<div class=\"col-md-3\">";

                        if (TabelaAvaliacao.Rows.Count > 0) { user += "<div class=\"panel panel-success\">"; }
                        else { user += "<div class=\"panel panel-danger\">"; }

                        user += "<div class=\"panel-heading\">" + Tabela.Rows[i][TabUtilizador.PrimeiroNome] + " " + Tabela.Rows[i][TabUtilizador.UltimoNome] + "</div>";

                        if (TabelaAvaliacao.Rows.Count > 0) { user += "<a href=\"/Resumo?val=" + Tabela.Rows[i][TabUtilizador.Id] + "\" style=\"text-decoration: none;\">"; }
                        else { user += "<a href=\"/Avaliacao?val=" + Tabela.Rows[i][TabUtilizador.Id] + "\" style=\"text-decoration: none;\">"; }
                        

                        user += "<div class=\"panel-body\" style=\"height: 100px;\">";

                        if (TabelaAvaliacao.Rows.Count > 0) { user += "<p style=\"margin-top: 20px; text-align: center;\"><b>Avaliação Completa</b></p>"; }
                        else { user += "<p style=\"margin-top: 20px; text-align: center;\"><b>Avaliação Pendente</b></p>"; }

                        user += "</div>";

                        user += "</a>";

                        user += "</div>";

                        user += "</div>";
                    }

                    DivFuncionarios.InnerHtml = user;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void BTAdicionaUser_Click(object sender, EventArgs e)
        {
            try
            {
                TabUtilizador.Metodo.Insert(3, TBLogin.Text, TBPassword.Text, TBPNome.Text, TBUNome.Text, DBNull.Value, DBNull.Value, TBEmail.Text, true);

                Response.Redirect(Request.RawUrl);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}