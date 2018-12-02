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
    public partial class Quadrante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ((PaginaBase)this.Master).Menu_Quadrantes.Attributes.Add("class", "active");

                if (IsPostBack == false)
                {
                    _CarregaDadosQdt();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _CarregaDadosQdt()
        {
            DataTable tabela = null;
            string[] Descricao = new string[4];
            int[] Peso = new int[4];

            try
            {
                tabela = TabQuadrante.Metodo.Select(TabQuadrante.Id + ">0");

                if (tabela.Rows.Count > 0)
                {
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        Descricao[i] = (tabela.Rows[i][TabQuadrante.Descricao]).ToString();
                        Peso[i] = Convert.ToInt32(tabela.Rows[i][TabQuadrante.Peso]);
                    }

                    LB1.InnerText = Descricao[0] + " (%)";
                    LB2.InnerText = Descricao[1] + " (%)";
                    LB3.InnerText = Descricao[2] + " (%)";
                    LB4.InnerText = Descricao[3] + " (%)";

                    TB1.Text = Peso[0].ToString();
                    TB2.Text = Peso[1].ToString();
                    TB3.Text = Peso[2].ToString();
                    TB4.Text = Peso[3].ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void BTGuardar_Click(object sender, EventArgs e)
        {
            DataTable tabela = null;
            try
            {
                if ((Convert.ToInt32(TB1.Text) + Convert.ToInt32(TB2.Text) + Convert.ToInt32(TB3.Text) + Convert.ToInt32(TB4.Text)) != 100)
                {
                    DivErro.InnerHtml = "<div class=\"alert alert-danger\"><strong>Erro:</strong> A soma do peso dos quadrantes deverá ser 100.</div>";
                }
                else
                {
                    tabela = TabQuadrante.Metodo.Select(TabQuadrante.Id + ">0");

                    TabQuadrante.Metodo.Update(tabela.Rows[0][TabQuadrante.Descricao].ToString(), Convert.ToInt32(TB1.Text), Convert.ToInt32(tabela.Rows[0][TabQuadrante.Id]));
                    TabQuadrante.Metodo.Update(tabela.Rows[1][TabQuadrante.Descricao].ToString(), Convert.ToInt32(TB2.Text), Convert.ToInt32(tabela.Rows[1][TabQuadrante.Id]));
                    TabQuadrante.Metodo.Update(tabela.Rows[2][TabQuadrante.Descricao].ToString(), Convert.ToInt32(TB3.Text), Convert.ToInt32(tabela.Rows[2][TabQuadrante.Id]));
                    TabQuadrante.Metodo.Update(tabela.Rows[3][TabQuadrante.Descricao].ToString(), Convert.ToInt32(TB4.Text), Convert.ToInt32(tabela.Rows[3][TabQuadrante.Id]));

                    Response.Redirect(Request.RawUrl);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}