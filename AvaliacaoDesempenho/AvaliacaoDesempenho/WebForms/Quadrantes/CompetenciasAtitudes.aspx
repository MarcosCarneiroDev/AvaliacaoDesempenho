<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaBase.Master" AutoEventWireup="true" CodeBehind="CompetenciasAtitudes.aspx.cs" Inherits="AvaliacaoDesempenho.WebForms.Quadrantes.CompetenciasAtitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="/Quadrantes"><i class="fa fa-list" style="color: #30a5ff;"></i> Quadrantes</a></li>
                <li>Competências e Atitudes</li>
            </ol>
        </div>
        
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <a href="/Quadrantes" class="btn btn-default"><i class="fa fa-arrow-left"></i></a>
                        <%--<a class="btn btn-default">Novo Parâmetro</a>--%>
                        <asp:Button ID="BTGuardar" runat="server" class="btn btn-primary pull-right" Text="Guardar" OnClick="BTGuardar_Click"></asp:Button>
                    </div>
                    <div class="panel-body" style="min-height:76vh;">

                        <div id="Erro" runat="server"></div>

                        <div class="row">

                            <div class="col-md-6">
                                <asp:TextBox ID="TBQuestao1" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao2" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao3" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao4" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao5" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao6" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao7" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao8" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao9" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBQuestao10" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                            </div>

                            <div class="col-md-2">
                                <asp:TextBox ID="TBPeso1" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso2" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso3" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso4" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso5" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso6" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso7" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso8" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso9" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                                <asp:TextBox ID="TBPeso10" runat="server" ClientIDMode="Static" CssClass="form-control" Style="margin-top: 10px;"></asp:TextBox>
                            </div>

                            <div class="col-md-1">
                                <a id="1" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="2" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="3" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="4" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="5" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="6" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="7" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="8" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="9" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                                <a id="10" class="btn btn-warning" style="margin-top: 10px;" onclick="reply_click(this.id)"><i class="fa fa-trash"></i> Limpar</a>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function reply_click(clicked_id) {
            $('#TBQuestao' + clicked_id).val('');
            $('#TBPeso' + clicked_id).val('');
        }
    </script>

</asp:Content>
