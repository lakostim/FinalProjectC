<%@ Page Language="C#" MasterPageFile="~/MasterContent/ApplicantWeb.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HRAppWebApp.Applicants.Register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
  <div class="login-container">

      <div class="input-box">
          <label>First Name</label>
          <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Last Name</label>
          <asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Email</label>
          <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Username</label>
          <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
      </div>
      <div class="input-box">
          <label>Password</label>
          <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
      </div>



      <div class="btn-register">
          <asp:Button ID="BRegister" runat="server" Text="Register"></asp:Button>
      </div>
      
  </div>

    <style>
        .login-container{
            padding: 2em;
        }

        .input-box{
            margin: 2em;
        }

        .btn-register{
           margin-left: 2em;
        }
    </style>
</asp:Content>