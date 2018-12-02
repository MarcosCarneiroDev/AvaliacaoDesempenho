<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaBase.Master" AutoEventWireup="true" CodeBehind="AvaliacaoDesempenho.aspx.cs" Inherits="AvaliacaoDesempenho.WebForms.AvaliacaoDesempenho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">

        <div class="row">
            <ol class="breadcrumb">
                <li><i class="fa fa-user" style="color:#30a5ff;"></i> Resumo</li>
            </ol>
        </div>				
		
		<div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Avaliação de <span id="NomeCompleto" runat="server"></span>
                        <span id="ClassificacaoFinal" runat="server"></span>
                    </div>
                    <div class="panel-body">                       

                        <div class="col-md-6">
                            <h3>Experiência de Trabalho</h3>
                            <div role="form">
                                <div class="form-group">
                                    <b><label id="ExpTrabalhoPontos" runat="server"></label> %</b>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <h3>Experiência na Posição</h3>
                            <div role="form">
                                <div class="form-group">
                                    <b><label id="ExpPosicaoPontos" runat="server"></label> %</b>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-12" style="border-bottom:solid 1px #eee; margin:10px 0 10px 0; padding:0;"></div>

                        <div class="col-md-12">
                            <h3 style="padding-bottom: 20px;">Performance Individual</h3>
                            <div role="form">

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance1" runat="server"></span> (<b><span id="Performance1Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance2" runat="server"></span> (<b><span id="Performance2Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance3" runat="server"></span> (<b><span id="Performance3Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance4" runat="server"></span> (<b><span id="Performance4Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance5" runat="server"></span> (<b><span id="Performance5Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance6" runat="server"></span> (<b><span id="Performance6Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance7" runat="server"></span> (<b><span id="Performance7Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance8" runat="server"></span> (<b><span id="Performance8Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance9" runat="server"></span> (<b><span id="Performance9Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Performance10" runat="server"></span> (<b><span id="Performance10Pontos" runat="server"></span> %</b>)
                                        </div>                                        
                                    </div>                                   
                                </div>

                            </div>
                        </div>

                        <div class="col-md-12" style="border-bottom:solid 1px #eee; margin:10px 0 10px 0; padding:0;"></div>

                        <div class="col-md-12">
                            <h3 style="padding-bottom: 20px;">Performance Individual</h3>
                            <div role="form">

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias1" runat="server"></span> (<b><span id="Competencias1Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias2" runat="server"></span> (<b><span id="Competencias2Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias3" runat="server"></span> (<b><span id="Competencias3Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias4" runat="server"></span> (<b><span id="Competencias4Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias5" runat="server"></span> (<b><span id="Competencias5Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias6" runat="server"></span> (<b><span id="Competencias6Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias7" runat="server"></span> (<b><span id="Competencias7Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias8" runat="server"></span> (<b><span id="Competencias8Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias9" runat="server"></span> (<b><span id="Competencias9Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                                <div class="form-group">
                                    <div class="row" style="padding-bottom: 20px;">
                                        <div class="col-md-12">
                                            <span id="Competencias10" runat="server"></span> (<b><span id="Competencias10Pontos" runat="server"></span> %</b>)
                                        </div>
                                    </div>                                   
                                </div>

                            </div> 
                        </div>

                    </div>
                </div>
            </div>
        </div>	
	</div>

</asp:Content>
