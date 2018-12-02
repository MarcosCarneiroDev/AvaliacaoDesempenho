<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaBase.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="AvaliacaoDesempenho.WebForms.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><i class="fa fa-dashboard" style="color:#30a5ff;"></i> Dashboard</li>
            </ol>
        </div>
        <!--/.row-->

        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Dashboard</h1>
            </div>
        </div>
        <!--/.row-->

        <div class="row">
            <div class="col-xs-12 col-md-6 col-lg-3">
                <div class="panel panel-blue panel-widget ">
                    <div class="row no-padding">
                        <div class="col-sm-3 col-lg-5 widget-left">
                            <svg class="glyph stroked male-user">
                                <use xlink:href="#stroked-male-user"></use></svg>
                        </div>
                        <div class="col-sm-9 col-lg-7 widget-right">
                            <div id="NumeroUtilizadores" runat="server" class="large"></div>
                            <div class="text-muted">Nº Funcionários</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-12 col-md-6 col-lg-3">
                <div class="panel panel-teal panel-widget">
                    <div class="row no-padding">
                        <div class="col-sm-3 col-lg-5 widget-left">
                            <svg class="glyph stroked app-window-with-content">
                                <use xlink:href="#stroked-app-window-with-content"></use></svg>
                        </div>
                        <div class="col-sm-9 col-lg-7 widget-right">
                            <div id="UtilAvaliacaoCompleta" runat="server" class="large"></div>
                            <div class="text-muted">Ava. Completas</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-12 col-md-6 col-lg-3">
                <div class="panel panel-red panel-widget">
                    <div class="row no-padding">
                        <div class="col-sm-3 col-lg-5 widget-left">
                            <svg class="glyph stroked notepad">
                            <svg class="glyph stroked app-window-with-content">
                                <use xlink:href="#stroked-app-window-with-content"></use></svg>
                        </div>
                        <div class="col-sm-9 col-lg-7 widget-right">
                            <div id="UtilAvaliacaoPendente" runat="server" class="large"></div>
                            <div class="text-muted">Ava. Pendentes</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-12 col-md-6 col-lg-3">
                <div class="panel panel-orange panel-widget">
                    <div class="row no-padding">
                        <div class="col-sm-3 col-lg-5 widget-left">
                            <svg class="glyph stroked line-graph">
                                <use xlink:href="#stroked-line-graph"></use></svg>
                        </div>
                        <div class="col-sm-9 col-lg-7 widget-right">
                            <div id="Acima50" runat="server" class="large"></div>
                            <div class="text-muted">> 50%</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--/.row-->

        <div class="row">
			<div class="col-md-6">
				<div class="panel panel-default">
					<div class="panel-heading">Performance Individual</div>
					<div class="panel-body">
						<div class="canvas-wrapper">
							<canvas class="chart" id="pie-chart-performance" height="228" width="458" style="width: 367px; height: 183px;"></canvas>
						</div>
					</div>
				</div>
			</div>
			<div class="col-md-6">
				<div class="panel panel-default">
					<div class="panel-heading">Competências e Atitudes</div>
					<div class="panel-body">
						<div class="canvas-wrapper">
							<canvas class="chart" id="pie-chart-competencias" height="228" width="458" style="width: 367px; height: 183px;"></canvas>
						</div>
					</div>
				</div>
			</div>
            <div class="col-md-6">
				<div class="panel panel-default">
					<div class="panel-heading">Experiência de Trabalho</div>
					<div class="panel-body">
						<div class="canvas-wrapper">
							<canvas class="chart" id="pie-chart-exptrabalho" height="228" width="458" style="width: 367px; height: 183px;"></canvas>
						</div>
					</div>
				</div>
			</div>
			<div class="col-md-6">
				<div class="panel panel-default">
					<div class="panel-heading">Experiência na Posição</div>
					<div class="panel-body">
						<div class="canvas-wrapper">
							<canvas class="chart" id="pie-chart-expposicao" height="228" width="458" style="width: 367px; height: 183px;"></canvas>
						</div>
					</div>
				</div>
			</div>
		</div>

        <%--<script>
            var piePerformance = [
                { value: 120, color: "#f9243f", highlight: "#f6495f", label: "Red" },
                { value: 50, color: "#ffb53e", highlight: "#fac878", label: "Orange" },
                { value: 300, color: "#30a5ff", highlight: "#62b9fb", label: "Blue" },            
                { value: 100, color: "#1ebfae", highlight: "#3cdfce", label: "Teal"}              
            ];

            var pieCompetencias = [
                { value: 10, color: "#f9243f", highlight: "#f6495f", label: "Red" },
                { value: 60, color: "#ffb53e", highlight: "#fac878", label: "Orange" },
                { value: 50, color: "#30a5ff", highlight: "#62b9fb", label: "Blue" },
                { value: 40, color: "#1ebfae", highlight: "#3cdfce", label: "Teal" }
            ];

            var pieExpTrabalho = [
                { value: 10, color: "#f9243f", highlight: "#f6495f", label: "Red" },
                { value: 60, color: "#ffb53e", highlight: "#fac878", label: "Orange" },
                { value: 50, color: "#30a5ff", highlight: "#62b9fb", label: "Blue" },
                { value: 40, color: "#1ebfae", highlight: "#3cdfce", label: "Teal" }
            ];

            var pieExpPosicao = [
                { value: 10, color: "#f9243f", highlight: "#f6495f", label: "Red" },
                { value: 60, color: "#ffb53e", highlight: "#fac878", label: "Orange" },
                { value: 50, color: "#30a5ff", highlight: "#62b9fb", label: "Blue" },
                { value: 40, color: "#1ebfae", highlight: "#3cdfce", label: "Teal" }
            ];

            window.onload = function () {
                var chart1 = document.getElementById("pie-chart-performance").getContext("2d");
                window.myPie = new Chart(chart1).Pie(piePerformance, {
                    responsive: true
                });

                var chart2 = document.getElementById("pie-chart-competencias").getContext("2d");
                window.myPie = new Chart(chart2).Pie(pieCompetencias, {
                    responsive: true
                });

                var chart3 = document.getElementById("pie-chart-exptrabalho").getContext("2d");
                window.myPie = new Chart(chart3).Pie(pieExpTrabalho, {
                    responsive: true
                });

                var chart4 = document.getElementById("pie-chart-expposicao").getContext("2d");
                window.myPie = new Chart(chart4).Pie(pieExpPosicao, {
                    responsive: true
                });
            };
        </script>--%>

        <div class="row">
            <div class="col-xs-6 col-md-3">
                <div class="panel panel-default">
                    <div class="panel-body easypiechart-panel">
                        <h4>Média Performance Individual</h4>
                        <div id="DivMediaQ1" runat="server"></div>
                        <%--<div class="easypiechart" id="easypiechart-blue" data-percent="92"><span class="percent"></span></div>--%>
                    </div>
                </div>
            </div>
            <div class="col-xs-6 col-md-3">
                <div class="panel panel-default">
                    <div class="panel-body easypiechart-panel">
                        <h4>Média Competências e Atitudes</h4>
                        <div id="DivMediaQ2" runat="server"></div>
                        <%--<div class="easypiechart" id="easypiechart-orange" data-percent="65">
                            <span class="percent"></span>
                        </div>--%>
                    </div>
                </div>
            </div>
            <div class="col-xs-6 col-md-3">
                <div class="panel panel-default">
                    <div class="panel-body easypiechart-panel">
                        <h4>Média Experiência na Posição</h4>
                        <div id="DivMediaQ3" runat="server"></div>
                        <%--<div class="easypiechart" id="easypiechart-teal" data-percent="56">
                            <span class="percent"></span>
                        </div>--%>
                    </div>
                </div>
            </div>
            <div class="col-xs-6 col-md-3">
                <div class="panel panel-default">
                    <div class="panel-body easypiechart-panel">
                        <h4>Média Experiência de Trabalho</h4>
                        <div id="DivMediaQ4" runat="server"></div>
                        <%--<div class="easypiechart" id="easypiechart-red" data-percent="27">
                            <span class="percent"></span>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
        <!--/.row-->


        
    </div>

</asp:Content>
