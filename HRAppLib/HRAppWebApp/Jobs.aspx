<%@ Page Language="C#" MasterPageFile="~/MasterContent/ApplicantWeb.Master" AutoEventWireup="true" CodeBehind="Jobs.aspx.cs" Inherits="HRAppWebApp.Jobs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <h3>View Avaliable Jobs<asp:ListView ID="ListView1" runat="server">
        </asp:ListView>
    </h3>

    <style>
        h3{
            text-align: center;
        }
    </style>

</asp:Content>