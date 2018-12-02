using ADFramework.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoDesempenho.WebForms.Quadrantes
{
    public partial class CompetenciasAtitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack != true)
            {
                _CarregaDados();
            }
        }

        private void _CarregaDados()
        {
            DataTable Tabela = null;

            try
            {

                Tabela = TabQuestao.Metodo.Select(TabQuestao.Qua_Id + "=1", TabQuestao.Id);

                if (Tabela.Rows.Count > 0)
                {

                    TBQuestao1.Text = Tabela.Rows[0][TabQuestao.Descricao].ToString();
                    TBQuestao2.Text = Tabela.Rows[1][TabQuestao.Descricao].ToString();
                    TBQuestao3.Text = Tabela.Rows[2][TabQuestao.Descricao].ToString();
                    TBQuestao4.Text = Tabela.Rows[3][TabQuestao.Descricao].ToString();
                    TBQuestao5.Text = Tabela.Rows[4][TabQuestao.Descricao].ToString();
                    TBQuestao6.Text = Tabela.Rows[5][TabQuestao.Descricao].ToString();
                    TBQuestao7.Text = Tabela.Rows[6][TabQuestao.Descricao].ToString();
                    TBQuestao8.Text = Tabela.Rows[7][TabQuestao.Descricao].ToString();
                    TBQuestao9.Text = Tabela.Rows[8][TabQuestao.Descricao].ToString();
                    TBQuestao10.Text = Tabela.Rows[9][TabQuestao.Descricao].ToString();

                    TBPeso1.Text = Tabela.Rows[0][TabQuestao.Peso].ToString();
                    TBPeso2.Text = Tabela.Rows[1][TabQuestao.Peso].ToString();
                    TBPeso3.Text = Tabela.Rows[2][TabQuestao.Peso].ToString();
                    TBPeso4.Text = Tabela.Rows[3][TabQuestao.Peso].ToString();
                    TBPeso5.Text = Tabela.Rows[4][TabQuestao.Peso].ToString();
                    TBPeso6.Text = Tabela.Rows[5][TabQuestao.Peso].ToString();
                    TBPeso7.Text = Tabela.Rows[6][TabQuestao.Peso].ToString();
                    TBPeso8.Text = Tabela.Rows[7][TabQuestao.Peso].ToString();
                    TBPeso9.Text = Tabela.Rows[8][TabQuestao.Peso].ToString();
                    TBPeso10.Text = Tabela.Rows[9][TabQuestao.Peso].ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void BTGuardar_Click(object sender, EventArgs e)
        {

            DataTable Tabela = null;
            string[] descricao = new string[10];
            string[] peso = new string[10];

            bool flagDesc = false;
            bool flagPeso = false;
            int somatorio = 0;

            try
            {
                descricao[0] = TBQuestao1.Text;
                descricao[1] = TBQuestao2.Text;
                descricao[2] = TBQuestao3.Text;
                descricao[3] = TBQuestao4.Text;
                descricao[4] = TBQuestao5.Text;
                descricao[5] = TBQuestao6.Text;
                descricao[6] = TBQuestao7.Text;
                descricao[7] = TBQuestao8.Text;
                descricao[8] = TBQuestao9.Text;
                descricao[9] = TBQuestao10.Text;

                peso[0] = TBPeso1.Text;
                peso[1] = TBPeso2.Text;
                peso[2] = TBPeso3.Text;
                peso[3] = TBPeso4.Text;
                peso[4] = TBPeso5.Text;
                peso[5] = TBPeso6.Text;
                peso[6] = TBPeso7.Text;
                peso[7] = TBPeso8.Text;
                peso[8] = TBPeso9.Text;
                peso[9] = TBPeso10.Text;

                for (int i=0; i<10; i++)
                {
                    if (descricao[i] == "")
                    {
                        flagDesc = true;
                    }

                    if (peso[i] == "")
                    {
                        flagPeso = true;
                    }

                    if(peso[i] != "")
                    {
                        somatorio += somatorio + Convert.ToInt32(peso[i]);
                    }
                    
                }

                if (flagDesc == true || flagPeso == true){
                    Erro.InnerHtml = "<div class=\"alert bg-danger\">Os campos têm de estar todos preenchidos.</div>";
                }
                else if (somatorio != 100)
                {
                    Erro.InnerHtml = "<div class=\"alert bg-danger\">O somatório de todas as questões terá de ser 100.</div>";
                }
                else
                {                

                    Tabela = TabQuestao.Metodo.Select(TabQuestao.Qua_Id + "=1", TabQuestao.Id);                

                    if (Tabela.Rows.Count > 0)
                    {
                    
                        for (int i = 0; i<10; i++)
                        { 
                            TabQuestao.Metodo.Update((int)Tabela.Rows[i][TabQuestao.Qua_Id],
                                descricao[i],
                                Convert.ToInt32(peso[i]),
                                (int)Tabela.Rows[i][TabQuestao.Id]);
                        }

                    }

                    Erro.InnerHtml = "";

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}