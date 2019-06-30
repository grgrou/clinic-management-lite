﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QEmployeeByPosArea.aspx.cs" Inherits="Views_QEmployeeByPosArea" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="wrapper">
        <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="container-fluid flex-header">
                <h4><a href="#">Clients</a></h4>
                <h4><a href="#">Employees</a></h4>
                <h4><a href="#">Areas</a></h4>
                <h4><a href="#">Permission</a></h4>
                <h4><a href="#">Position</a></h4>
                <!--Rplc Button--><h4><a href="#"> <i class="fa fa-sign-out fa-fw"></i> Logout</a></h4>
            </div>
        </nav>
        <div id="page-wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <!--Rplc label--><h1>Employee by area and position</h1>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <div class="row" style="margin-top: 16px;">
                <div class="col-sm-1 col-md-1 col-lg-2"></div>
                <div class="col-sm-10 col-md-10 col-lg-8 buttons-container">
                    <div class="form-group" style="margin: 6px 6px 0px 6px">
                        <asp:DropDownList ID="dropArea" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropArea_SelectedIndexChanged">
                            <asp:ListItem Value="-1">--</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group" style="margin: 6px 6px 0px 6px">
                        <asp:DropDownList ID="dropPosition" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropPosition_SelectedIndexChanged1">
                            <asp:ListItem Value="-1">--</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button ID="btnQuery" runat="server" Text="Consultar" CssClass="btn btn-lg btn-success" style="margin: 0px 6px 0px 6px" OnClick="btnQuery_Click"/>
                </div>
            </div>
            <div class="row" style="margin-top: 16px;">
                <div class="col-sm-1 col-md-1 col-lg-2"></div>
                <div class="col-sm-10 col-md-10 col-lg-8">
                    <p class="bg-danger" style="border-radius: 12px;">
                        <asp:Label ID="lblMessageDanger" CssClass="login-error-message" runat="server" Visible="false">Danger</asp:Label>
                    </p>
                    <p class="bg-warning" style="border-radius: 12px;">
                        <asp:Label ID="lblMessageWarning" CssClass="login-error-message" runat="server" Visible="False">Warning</asp:Label>
                    </p>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-1 col-md-1 col-lg-2"></div>
                <div class="col-sm-10 col-md-10 col-lg-8">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                        Query
                        </div>

                        <div class="panel-body">
                            <asp:GridView ID="gdvClients" width="100%" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="name" HeaderText="Nombre" />
                                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                    <asp:BoundField DataField="phone" HeaderText="Phone" />
                                    <asp:BoundField DataField="address" HeaderText="Address" />
                                    <asp:BoundField DataField="email" HeaderText="Email" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
                <div class="col-sm-1 col-md-1 col-lg-2"></div>
            </div>
        </div>
    </div>
</asp:Content>
