<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaBase.Master" AutoEventWireup="true" CodeBehind="Funcionarios.aspx.cs" Inherits="AvaliacaoDesempenho.WebForms.Funcionarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">			
		
        <div class="row">
			<ol class="breadcrumb">
				<li><a href="#"><i class="fa fa-users"></i></a></li>
				<li class="active">Funcionários</li>
			</ol>
		</div>
		
		<div class="row" style="padding:20px 0 20px 0;">
			<div class="col-lg-12">
				<a class="btn btn-primary" data-toggle="modal" data-target="#myModal">Adicionar Funcionário</a>
			</div>
		</div>		
		
		<div id="DivFuncionarios" runat="server" class="row">
			<%--<div class="col-md-3">
				<div class="panel panel-success">
					<div class="panel-heading">Nome Funcionário</div>
                    <a href="#" style="text-decoration: none;">
                        <div class="panel-body" style="height: 100px;">
                            <p style="margin-top: 20px; text-align: center;"><b>Avaliação Completa</b></p>
                        </div>
                    </a>
				</div>
			</div>

            <div class="col-md-3">
				<div class="panel panel-danger">
					<div class="panel-heading">Nome Funcionário</div>
                    <a href="#" style="text-decoration: none;">
                        <div class="panel-body" style="height: 100px;">
                            <p style="margin-top: 20px; text-align: center;"><b>Avaliação Pendente</b></p>
                        </div>
                    </a>
				</div>
			</div>

            <div class="col-md-3">
				<div class="panel panel-danger">
					<div class="panel-heading">Nome Funcionário</div>
                    <a href="#" style="text-decoration: none;">
                        <div class="panel-body" style="height: 100px;">
                            <p style="margin-top: 20px; text-align: center;"><b>Avaliação Pendente</b></p>
                        </div>
                    </a>
				</div>
			</div>

            <div class="col-md-3">
				<div class="panel panel-danger">
					<div class="panel-heading">Nome Funcionário</div>
                    <a href="#" style="text-decoration: none;">
                        <div class="panel-body" style="height: 100px;">
                            <p style="margin-top: 20px; text-align: center;"><b>Avaliação Pendente</b></p>
                        </div>
                    </a>
				</div>
			</div>

            <div class="col-md-3">
				<div class="panel panel-danger">
					<div class="panel-heading">Nome Funcionário</div>
                    <a href="#" style="text-decoration: none;">
                        <div class="panel-body" style="height: 100px;">
                            <p style="margin-top: 20px; text-align: center;"><b>Avaliação Pendente</b></p>
                        </div>
                    </a>
				</div>
			</div>--%>
		</div>
	</div>

    <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog">
            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Adicionar Funcionário</h4>
                </div>
                <div class="modal-body" style="">

                    <div class="form-group" >
                        <asp:TextBox ID="TBLogin" runat="server" class="form-control" style="margin-bottom:10px;" placeholder="Utilizador"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="TBPassword" runat="server" TextMode="Password" style="margin-bottom:10px;" class="form-control" placeholder="Password"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="TBPNome" runat="server" class="form-control" style="margin-bottom:10px;" placeholder="Primeiro Nome"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="TBUNome" runat="server" class="form-control" style="margin-bottom:10px;" placeholder="Último Nome"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="TBEmail" runat="server" TextMode="Email" class="form-control" placeholder="Email"></asp:TextBox>
                    </div>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <asp:Button ID="BTAdicionaUser" runat="server" CssClass="btn btn-success" Text="Guardar" OnClick="BTAdicionaUser_Click" />
                </div>
            </div>

        </div>
    </div>
    
</asp:Content>
