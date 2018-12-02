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
    public partial class Avaliacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            try
            {
                string UtiId = Request.QueryString["val"];

                if (IsPostBack == false)
                {                
                    _VerificaUtilizador(UtiId);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void _VerificaUtilizador(string UtiId)
        {
            DataTable Tabela = null;

            try
            {
                if (UtiId == null || UtiId == "")
                {
                    Response.Redirect("/Funcionarios");
                }
                else
                {
                    Tabela = TabUtilizador.Metodo.Select(TabUtilizador.Id + "=" + UtiId);

                    if (Tabela.Rows.Count > 0)
                    {
                        NomeCompleto.InnerText = Tabela.Rows[0][TabUtilizador.PrimeiroNome].ToString() + " " + Tabela.Rows[0][TabUtilizador.UltimoNome].ToString();
                        _CarregaQuestoes(UtiId);
                    }
                    else
                    {
                        Response.Redirect("/Funcionarios");
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

        private void _CarregaQuestoes(string UtiId)
        {
            DataTable TabelaPerformance = null;
            DataTable TabelaCompetencias = null;
            DataTable ClassificacaoPerformance = null;
            DataTable ClassificacaoCompetencias = null;

            try
            {
                TabelaPerformance = TabQuestao.Metodo.Select(TabQuestao.Qua_Id + "=1", TabQuestao.Id);
                TabelaCompetencias = TabQuestao.Metodo.Select(TabQuestao.Qua_Id + "=2", TabQuestao.Id);
                ClassificacaoPerformance = TabClassificacao.Metodo.Select(TabClassificacao.Qua_Id + "=1", TabClassificacao.Id);
                ClassificacaoCompetencias = TabClassificacao.Metodo.Select(TabClassificacao.Qua_Id + "=2", TabClassificacao.Id);

                Performance1.InnerHtml = TabelaPerformance.Rows[0][TabQuestao.Descricao].ToString();
                Performance2.InnerHtml = TabelaPerformance.Rows[1][TabQuestao.Descricao].ToString();
                Performance3.InnerHtml = TabelaPerformance.Rows[2][TabQuestao.Descricao].ToString();
                Performance4.InnerHtml = TabelaPerformance.Rows[3][TabQuestao.Descricao].ToString();
                Performance5.InnerHtml = TabelaPerformance.Rows[4][TabQuestao.Descricao].ToString();
                Performance6.InnerHtml = TabelaPerformance.Rows[5][TabQuestao.Descricao].ToString();
                Performance7.InnerHtml = TabelaPerformance.Rows[6][TabQuestao.Descricao].ToString();
                Performance8.InnerHtml = TabelaPerformance.Rows[7][TabQuestao.Descricao].ToString();
                Performance9.InnerHtml = TabelaPerformance.Rows[8][TabQuestao.Descricao].ToString();
                Performance10.InnerHtml = TabelaPerformance.Rows[9][TabQuestao.Descricao].ToString();

                DDPerformance1.DataSource = ClassificacaoPerformance;
                DDPerformance1.DataTextField = TabClassificacao.Descricao;
                DDPerformance1.DataValueField = TabClassificacao.Cotacao;
                DDPerformance1.DataBind();

                DDPerformance2.DataSource = ClassificacaoPerformance;
                DDPerformance2.DataTextField = TabClassificacao.Descricao;
                DDPerformance2.DataValueField = TabClassificacao.Cotacao;
                DDPerformance2.DataBind();

                DDPerformance3.DataSource = ClassificacaoPerformance;
                DDPerformance3.DataTextField = TabClassificacao.Descricao;
                DDPerformance3.DataValueField = TabClassificacao.Cotacao;
                DDPerformance3.DataBind();

                DDPerformance4.DataSource = ClassificacaoPerformance;
                DDPerformance4.DataTextField = TabClassificacao.Descricao;
                DDPerformance4.DataValueField = TabClassificacao.Cotacao;
                DDPerformance4.DataBind();

                DDPerformance5.DataSource = ClassificacaoPerformance;
                DDPerformance5.DataTextField = TabClassificacao.Descricao;
                DDPerformance5.DataValueField = TabClassificacao.Cotacao;
                DDPerformance5.DataBind();

                DDPerformance6.DataSource = ClassificacaoPerformance;
                DDPerformance6.DataTextField = TabClassificacao.Descricao;
                DDPerformance6.DataValueField = TabClassificacao.Cotacao;
                DDPerformance6.DataBind();

                DDPerformance7.DataSource = ClassificacaoPerformance;
                DDPerformance7.DataTextField = TabClassificacao.Descricao;
                DDPerformance7.DataValueField = TabClassificacao.Cotacao;
                DDPerformance7.DataBind();

                DDPerformance8.DataSource = ClassificacaoPerformance;
                DDPerformance8.DataTextField = TabClassificacao.Descricao;
                DDPerformance8.DataValueField = TabClassificacao.Cotacao;
                DDPerformance8.DataBind();

                DDPerformance9.DataSource = ClassificacaoPerformance;
                DDPerformance9.DataTextField = TabClassificacao.Descricao;
                DDPerformance9.DataValueField = TabClassificacao.Cotacao;
                DDPerformance9.DataBind();

                DDPerformance10.DataSource = ClassificacaoPerformance;
                DDPerformance10.DataTextField = TabClassificacao.Descricao;
                DDPerformance10.DataValueField = TabClassificacao.Cotacao;
                DDPerformance10.DataBind();

                Competencias1.InnerHtml = TabelaCompetencias.Rows[0][TabQuestao.Descricao].ToString();
                Competencias2.InnerHtml = TabelaCompetencias.Rows[1][TabQuestao.Descricao].ToString();
                Competencias3.InnerHtml = TabelaCompetencias.Rows[2][TabQuestao.Descricao].ToString();
                Competencias4.InnerHtml = TabelaCompetencias.Rows[3][TabQuestao.Descricao].ToString();
                Competencias5.InnerHtml = TabelaCompetencias.Rows[4][TabQuestao.Descricao].ToString();
                Competencias6.InnerHtml = TabelaCompetencias.Rows[5][TabQuestao.Descricao].ToString();
                Competencias7.InnerHtml = TabelaCompetencias.Rows[6][TabQuestao.Descricao].ToString();
                Competencias8.InnerHtml = TabelaCompetencias.Rows[7][TabQuestao.Descricao].ToString();
                Competencias9.InnerHtml = TabelaCompetencias.Rows[8][TabQuestao.Descricao].ToString();
                Competencias10.InnerHtml = TabelaCompetencias.Rows[9][TabQuestao.Descricao].ToString();

                DDCompetencias1.DataSource = ClassificacaoCompetencias;
                DDCompetencias1.DataTextField = TabClassificacao.Descricao;
                DDCompetencias1.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias1.DataBind();

                DDCompetencias2.DataSource = ClassificacaoCompetencias;
                DDCompetencias2.DataTextField = TabClassificacao.Descricao;
                DDCompetencias2.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias2.DataBind();

                DDCompetencias3.DataSource = ClassificacaoCompetencias;
                DDCompetencias3.DataTextField = TabClassificacao.Descricao;
                DDCompetencias3.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias3.DataBind();

                DDCompetencias4.DataSource = ClassificacaoCompetencias;
                DDCompetencias4.DataTextField = TabClassificacao.Descricao;
                DDCompetencias4.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias4.DataBind();

                DDCompetencias5.DataSource = ClassificacaoCompetencias;
                DDCompetencias5.DataTextField = TabClassificacao.Descricao;
                DDCompetencias5.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias5.DataBind();

                DDCompetencias6.DataSource = ClassificacaoCompetencias;
                DDCompetencias6.DataTextField = TabClassificacao.Descricao;
                DDCompetencias6.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias6.DataBind();

                DDCompetencias7.DataSource = ClassificacaoCompetencias;
                DDCompetencias7.DataTextField = TabClassificacao.Descricao;
                DDCompetencias7.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias7.DataBind();

                DDCompetencias8.DataSource = ClassificacaoCompetencias;
                DDCompetencias8.DataTextField = TabClassificacao.Descricao;
                DDCompetencias8.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias8.DataBind();

                DDCompetencias9.DataSource = ClassificacaoCompetencias;
                DDCompetencias9.DataTextField = TabClassificacao.Descricao;
                DDCompetencias9.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias9.DataBind();

                DDCompetencias10.DataSource = ClassificacaoCompetencias;
                DDCompetencias10.DataTextField = TabClassificacao.Descricao;
                DDCompetencias10.DataValueField = TabClassificacao.Cotacao;
                DDCompetencias10.DataBind();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void BTSubmeter_Click(object sender, EventArgs e)
        {
            string UtiId = Request.QueryString["val"];
            DataTable TabelaQuadrantes = null;
            DataTable TabelaQuestoesPerformance = null;
            DataTable TabelaQuestoesCompetencias = null;
            int Q1Peso = 0;
            int Q2Peso = 0;
            int Q3Peso = 0;
            int Q4Peso = 0;
            decimal Classificacao1 = 0;
            decimal Classificacao2 = 0;
            decimal Classificacao3 = 0;
            decimal Classificacao4 = 0;
            decimal ClassificacaoFinal = 0;

            object IdAvaliacao = 0;

            try
            {
                TabelaQuadrantes = TabQuadrante.Metodo.Select(TabQuadrante.Id + ">0", TabQuadrante.Id);

                Q1Peso = Convert.ToInt32(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]);
                Q2Peso = Convert.ToInt32(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]);
                Q3Peso = Convert.ToInt32(TabelaQuadrantes.Rows[2][TabQuadrante.Peso]);
                Q4Peso = Convert.ToInt32(TabelaQuadrantes.Rows[3][TabQuadrante.Peso]);

                TabelaQuestoesPerformance = TabQuestao.Metodo.Select(TabQuestao.Qua_Id + "=1", TabQuestao.Id);

                Classificacao1 = (Convert.ToInt32(TabelaQuestoesPerformance.Rows[0][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance1.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[1][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance2.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[2][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance3.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[3][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance4.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[4][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance5.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[5][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance6.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[6][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance7.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[7][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance8.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[8][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance9.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesPerformance.Rows[9][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance10.SelectedValue));

                TabelaQuestoesCompetencias = TabQuestao.Metodo.Select(TabQuestao.Qua_Id + "=2", TabQuestao.Id);

                Classificacao2 = (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[0][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias1.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[1][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias2.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[2][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias3.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[3][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias4.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[4][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias5.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[5][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias6.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[6][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias7.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[7][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias8.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[8][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias9.SelectedValue)) +
                    (Convert.ToInt32(TabelaQuestoesCompetencias.Rows[9][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias10.SelectedValue));

                if (Convert.ToInt32(TBExpPosicao.Text) < 3){ Classificacao3 = 20; }
                else if (Convert.ToInt32(TBExpPosicao.Text) < 5) { Classificacao3 = 40; }
                else if (Convert.ToInt32(TBExpPosicao.Text) < 8) { Classificacao3 = 60; }
                else if (Convert.ToInt32(TBExpPosicao.Text) < 10) { Classificacao3 = 80; }
                else if (Convert.ToInt32(TBExpPosicao.Text) >= 10) { Classificacao3 = 100; }

                if (Convert.ToInt32(TBExpTrabalho.Text) < 3) { Classificacao4 = 20; }
                else if (Convert.ToInt32(TBExpTrabalho.Text) < 5) { Classificacao4 = 40; }
                else if (Convert.ToInt32(TBExpTrabalho.Text) < 8) { Classificacao4 = 60; }
                else if (Convert.ToInt32(TBExpTrabalho.Text) < 10) { Classificacao4 = 80; }
                else if (Convert.ToInt32(TBExpTrabalho.Text) >= 10) { Classificacao4 = 100; }

                ClassificacaoFinal = (Classificacao1 * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)) + (Classificacao2 * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)) + (Classificacao3 * (Convert.ToDecimal(TabelaQuadrantes.Rows[2][TabQuadrante.Peso]) / 100)) + (Classificacao4 * (Convert.ToDecimal(TabelaQuadrantes.Rows[3][TabQuadrante.Peso]) / 100));

                IdAvaliacao = TabAvaliacao.Metodo.Insert(Convert.ToInt32(UtiId), Q1Peso, Q2Peso, Q3Peso, Q4Peso, Convert.ToInt32(Classificacao1), Convert.ToInt32(Classificacao2), Convert.ToInt32(Classificacao3), Convert.ToInt32(Classificacao4), Convert.ToInt32(ClassificacaoFinal));

                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[0][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[0][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[0][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance1.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[0][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance1.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[1][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[1][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[1][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance2.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[1][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance2.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[2][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[2][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[2][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance3.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[2][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance3.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[3][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[3][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[3][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance4.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[3][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance4.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[4][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[4][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[4][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance5.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[4][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance5.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[5][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[5][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[5][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance6.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[5][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance6.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[6][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[6][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[6][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance7.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[6][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance7.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[7][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[7][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[7][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance8.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[7][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance8.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[8][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[8][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[8][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance9.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[8][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance9.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 1, Q1Peso, TabelaQuestoesPerformance.Rows[9][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesPerformance.Rows[9][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesPerformance.Rows[9][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance10.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesPerformance.Rows[9][TabQuestao.Peso]) * Convert.ToDecimal(DDPerformance10.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[0][TabQuadrante.Peso]) / 100)));

                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[0][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[0][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[0][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias1.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[0][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias1.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[1][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[1][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[1][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias2.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[1][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias2.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[2][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[2][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[2][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias3.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[2][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias3.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[3][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[3][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[3][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias4.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[3][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias4.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[4][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[4][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[4][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias5.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[4][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias5.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[5][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[5][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[5][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias6.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[5][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias6.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[6][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[6][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[6][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias7.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[6][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias7.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[7][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[7][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[7][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias8.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[7][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias8.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[8][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[8][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[8][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias9.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[8][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias9.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 2, Q2Peso, TabelaQuestoesCompetencias.Rows[9][TabQuestao.Descricao].ToString(), Convert.ToInt32(TabelaQuestoesCompetencias.Rows[9][TabQuestao.Peso]), Convert.ToInt32(Convert.ToInt32(TabelaQuestoesCompetencias.Rows[9][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias10.SelectedValue)), Convert.ToInt32((Convert.ToInt32(TabelaQuestoesCompetencias.Rows[9][TabQuestao.Peso]) * Convert.ToDecimal(DDCompetencias10.SelectedValue)) * (Convert.ToDecimal(TabelaQuadrantes.Rows[1][TabQuadrante.Peso]) / 100)));

                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 3, Q3Peso, "Número de anos na Posição", 100, Convert.ToInt32(Classificacao3), Convert.ToInt32(Convert.ToInt32(Classificacao3) * (Convert.ToDecimal(TabelaQuadrantes.Rows[2][TabQuadrante.Peso]) / 100)));
                TabLinhaAvaliacao.Metodo.Insert(Convert.ToInt32(IdAvaliacao), 4, Q4Peso, "Número de anos na Trabalho", 100, Convert.ToInt32(Classificacao4), Convert.ToInt32(Convert.ToInt32(Classificacao4) * (Convert.ToDecimal(TabelaQuadrantes.Rows[3][TabQuadrante.Peso]) / 100)));

                Response.Redirect("/Funcionarios");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}