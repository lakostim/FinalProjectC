<%@ Page Language="C#" MasterPageFile="~/MasterContent/ApplicantWeb.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HRAppWebApp.Applicants.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
  <div class="login-container">
      <div class="input-box">
          <label>Username</label>
          <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
      </div>
      <div class="input-box">
          <label>Password</label>
          <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
      </div>
      <div class="btn-login">
          <asp:Button ID="BLogin" runat="server" Text="Login" OnClick="OnRequestLogin"></asp:Button>
      </div>
      
  </div>

    <style>
        .login-container{
            padding: 2em;
        }

        .input-box{
            margin: 2em;
        }

        .btn-login{
           margin-left: 2em;
        }
    </style>
</asp:Content>
