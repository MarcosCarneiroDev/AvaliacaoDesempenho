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
    public partial class AvaliacaoDesempenho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable user = null;

            try
            {
                if (Session["User"] != null)
                {
                    user = (DataTable)(Session["User"]);

                    if (user.Rows.Count > 0)
                    {
                        string UtiId = user.Rows[0][TabUtilizador.Id].ToString();

                        if (IsPostBack == false)
                        {
                            _CarregaDados(UtiId);
                        }
                    }
                }
                                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _CarregaDados(string UtiId)
        {
            DataTable TabelaUtilizador = null;
            DataTable TabelaAvaliacao = null;
            DataTable TabelaLinhaAva = null;

            try
            {

                TabelaUtilizador = TabUtilizador.Metodo.Select(TabUtilizador.Id + "=" + UtiId);
                TabelaAvaliacao = TabAvaliacao.Metodo.Select(TabAvaliacao.Uti_Id + "=" + UtiId);
                TabelaLinhaAva = TabLinhaAvaliacao.Metodo.Select(TabLinhaAvaliacao.Ava_Id + "=" + TabelaAvaliacao.Rows[0][TabAvaliacao.Id]);

                NomeCompleto.InnerText = TabelaUtilizador.Rows[0][TabUtilizador.PrimeiroNome].ToString() + " " + TabelaUtilizador.Rows[0][TabUtilizador.UltimoNome].ToString();

                if (Convert.ToInt32(TabelaAvaliacao.Rows[0][TabAvaliacao.Classificacao_Final]) > 50)
                {
                    ClassificacaoFinal.InnerHtml = "<span class=\"img-circle pull-right\" style=\"background-color:green; color:#fff; margin-right:10px; width:50px; height:50px; text-align:center; padding-top:3px; font-weight:bold;\">" + TabelaAvaliacao.Rows[0][TabAvaliacao.Classificacao_Final].ToString() + "%</span>";
                }
                else
                {
                    ClassificacaoFinal.InnerHtml = "<span class=\"img-circle pull-right\" style=\"background-color:red; color:#fff; margin-right:10px; width:50px; height:50px; text-align:center; padding-top:3px; font-weight:bold;\">" + TabelaAvaliacao.Rows[0][TabAvaliacao.Classificacao_Final].ToString() + "%</span>";
                }

                ExpTrabalhoPontos.InnerText = TabelaLinhaAva.Rows[21][TabLinhaAvaliacao.Classificacao].ToString();
                ExpPosicaoPontos.InnerText = TabelaLinhaAva.Rows[20][TabLinhaAvaliacao.Classificacao].ToString();

                Performance1.InnerText = TabelaLinhaAva.Rows[0][TabLinhaAvaliacao.Questao].ToString();
                Performance1Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[0][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance2.InnerText = TabelaLinhaAva.Rows[1][TabLinhaAvaliacao.Questao].ToString();
                Performance2Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[1][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance3.InnerText = TabelaLinhaAva.Rows[2][TabLinhaAvaliacao.Questao].ToString();
                Performance3Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[2][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance4.InnerText = TabelaLinhaAva.Rows[3][TabLinhaAvaliacao.Questao].ToString();
                Performance4Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[3][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance5.InnerText = TabelaLinhaAva.Rows[4][TabLinhaAvaliacao.Questao].ToString();
                Performance5Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[4][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance6.InnerText = TabelaLinhaAva.Rows[5][TabLinhaAvaliacao.Questao].ToString();
                Performance6Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[5][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance7.InnerText = TabelaLinhaAva.Rows[6][TabLinhaAvaliacao.Questao].ToString();
                Performance7Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[6][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance8.InnerText = TabelaLinhaAva.Rows[7][TabLinhaAvaliacao.Questao].ToString();
                Performance8Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[7][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance9.InnerText = TabelaLinhaAva.Rows[8][TabLinhaAvaliacao.Questao].ToString();
                Performance9Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[8][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Performance10.InnerText = TabelaLinhaAva.Rows[9][TabLinhaAvaliacao.Questao].ToString();
                Performance10Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[9][TabLinhaAvaliacao.Classificacao]) * 10).ToString();

                Competencias1.InnerText = TabelaLinhaAva.Rows[10][TabLinhaAvaliacao.Questao].ToString();
                Competencias1Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[10][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias2.InnerText = TabelaLinhaAva.Rows[11][TabLinhaAvaliacao.Questao].ToString();
                Competencias2Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[11][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias3.InnerText = TabelaLinhaAva.Rows[12][TabLinhaAvaliacao.Questao].ToString();
                Competencias3Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[12][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias4.InnerText = TabelaLinhaAva.Rows[13][TabLinhaAvaliacao.Questao].ToString();
                Competencias4Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[13][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias5.InnerText = TabelaLinhaAva.Rows[14][TabLinhaAvaliacao.Questao].ToString();
                Competencias5Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[14][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias6.InnerText = TabelaLinhaAva.Rows[15][TabLinhaAvaliacao.Questao].ToString();
                Competencias6Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[15][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias7.InnerText = TabelaLinhaAva.Rows[16][TabLinhaAvaliacao.Questao].ToString();
                Competencias7Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[16][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias8.InnerText = TabelaLinhaAva.Rows[17][TabLinhaAvaliacao.Questao].ToString();
                Competencias8Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[17][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias9.InnerText = TabelaLinhaAva.Rows[18][TabLinhaAvaliacao.Questao].ToString();
                Competencias9Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[18][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
                Competencias10.InnerText = TabelaLinhaAva.Rows[19][TabLinhaAvaliacao.Questao].ToString();
                Competencias10Pontos.InnerText = (Convert.ToInt32(TabelaLinhaAva.Rows[19][TabLinhaAvaliacao.Classificacao]) * 10).ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}