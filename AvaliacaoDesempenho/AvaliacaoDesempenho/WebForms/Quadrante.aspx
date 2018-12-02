<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaBase.Master" AutoEventWireup="true" CodeBehind="Quadrante.aspx.cs" Inherits="AvaliacaoDesempenho.WebForms.Quadrante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">

        <div class="row">
            <ol class="breadcrumb">
                <li><i class="fa fa-list" style="color:#30a5ff;"></i> Quadrantes</li>
            </ol>
        </div>				
		
		<div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">Definições</div>
                    <div class="panel-body">

                        
                        <div id="DivErro" runat="server"></div>
                        <div class="col-md-3">
                            <div role="form">
                                <div class="form-group">
                                    <label id="LB1" runat="server"></label>
                                    <asp:TextBox ID="TB1" runat="server" class="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label id="LB2" runat="server"></label>
                                    <asp:TextBox ID="TB2" runat="server" class="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div role="form">
                                <div class="form-group">
                                    <label id="LB3" runat="server"></label>
                                    <asp:TextBox ID="TB3" runat="server" class="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label id="LB4" runat="server"></label>
                                    <asp:TextBox ID="TB4" runat="server" class="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6" style="padding-top:100px;">
                            <asp:button id="BTGuardar" runat="server" type="submit" class="btn btn-primary pull-right" Text="Guardar" OnClick="BTGuardar_Click"></asp:button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
			<div class="col-md-6">
				<div class="panel panel-blue">
					<div class="panel-heading dark-overlay">Performance Individual</div>
                    <a href="/Quadrantes/Performance" style="text-decoration: none;">
                        <div class="panel-body" style="height: 100px;">
                            <p style="padding-top: 25px; text-align: center;"><i class="fa fa-pencil"></i> Editar Quadrante</p>
                        </div>
                    </a>
				</div>
			</div>
			<div class="col-md-6">
				<div class="panel panel-teal">
					<div class="panel-heading dark-overlay">Competências e Atitudes</div>
					<a href="/Quadrantes/Competencias" style="text-decoration: none;">
                        <div class="panel-body" style="height: 100px;">
                            <p style="padding-top: 25px; text-align: center;"><i class="fa fa-pencil"></i> Editar Quadrante</p>
                        </div>
                    </a>
				</div>
			</div>			
			<div class="col-md-6">
				<div class="panel panel-orange">
					<div class="panel-heading dark-overlay">Experiência na posição</div>
                    <div class="panel-body" style="height: 100px; cursor:not-allowed;">
                        <p style="padding-top: 25px; text-align: center;"><i class="fa fa-lock"></i> Indisponível</p>
                    </div>
				</div>
			</div>			
			<div class="col-md-6">
				<div class="panel panel-red">
					<div class="panel-heading dark-overlay">Experiência de trabalho</div>
                    <div class="panel-body" style="height: 100px; cursor:not-allowed;">
                        <p style="padding-top: 25px; text-align: center;"><i class="fa fa-lock"></i> Indisponível</p>
                    </div>
				</div>
			</div>
		</div>		
	</div>

</asp:Content>
