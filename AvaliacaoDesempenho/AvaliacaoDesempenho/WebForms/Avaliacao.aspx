<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaBase.Master" AutoEventWireup="true" CodeBehind="Avaliacao.aspx.cs" Inherits="AvaliacaoDesempenho.WebForms.Avaliacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">

        <div class="row">
            <ol class="breadcrumb">
                <li><i class="fa fa-user" style="color:#30a5ff;"></i> Avaliação</li>
            </ol>
        </div>				
		
		<div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">Avaliação de <span id="NomeCompleto" runat="server"></span></div>
                    <div class="panel-body">
                        
                        <div id="DivErro" runat="server"></div>

                        <div class="col-md-6">
                            <h3>Experiência de Trabalho</h3>
                            <div role="form">
                                <div class="form-group">
                                    <asp:TextBox ID="TBExpTrabalho" runat="server" class="form-control" Text="0"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <h3>Experiência na Posição</h3>
                            <div role="form">
                                <div class="form-group">
                                    <asp:TextBox ID="TBExpPosicao" runat="server" class="form-control" Text="0"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-12" style="border-bottom:solid 1px #eee; margin:10px 0 10px 0; padding:0;"></div>

                        <div class="col-md-12">
                            <h3 style="padding-bottom: 20px;">Performance Individual</h3>
                            <div role="form">

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance1" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance1" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance2" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance2" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance3" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance3" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance4" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance4" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance5" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance5" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance6" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance6" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance7" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance7" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance8" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance8" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance9" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance9" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Performance10" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDPerformance10" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                            </div>
                        </div>

                        <div class="col-md-12">
                            <h3 style="padding-bottom: 20px;">Performance Individual</h3>
                            <div role="form">

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias1" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias1" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias2" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias2" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias3" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias3" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias4" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias4" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias5" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias5" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias6" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias6" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias7" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias7" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias8" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias8" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias9" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias9" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-6">
                                            <p id="Competencias10" runat="server"></p>
                                        </div>
                                        <div class="col-md-3">
                                            <asp:DropDownList ID="DDCompetencias10" runat="server" class="form-control col-md-6"></asp:DropDownList>
                                        </div>
                                    </div>                                   
                                </div>

                            </div>
                            <asp:Button ID="BTSubmeter" runat="server" CssClass="btn btn-success pull-right" Text="Submeter" OnClick="BTSubmeter_Click" />
                        </div>

                    </div>
                </div>
            </div>
        </div>	
	</div>

</asp:Content>
