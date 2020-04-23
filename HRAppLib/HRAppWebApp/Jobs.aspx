<%@ Page Language="C#" MasterPageFile="~/MasterContent/ApplicantWeb.Master" AutoEventWireup="true" CodeBehind="Jobs.aspx.cs" Inherits="HRAppWebApp.Jobs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <h3>View Avaliable Jobs<asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Description], [Responsibilities], [Experience], [Requirements] FROM [Job]"></asp:SqlDataSource>
    </h3>

    <style>
        h3{
            text-align: center;
        }
    </style>

</asp:Content>