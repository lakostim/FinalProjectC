 <%@ Page Language="C#" MasterPageFile="~/MasterContent/ApplicantWeb.Master" AutoEventWireup="true" CodeBehind="Application.aspx.cs" Inherits="HRAppWebApp.Application" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
  <div class="login-container">

      <h3>Fill out the form below to apply</h3>

      <div class="input-box">
          <label>First Name</label>
          <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Last Name</label>
          <asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Address</label>
          <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Previous Job</label>
          <asp:TextBox ID="TxtPreviousJob" runat="server"></asp:TextBox>
      </div>
      <div class="input-box">
          <label>Phone</label>
          <asp:TextBox ID="TxtPhone" runat="server" TextMode="Number"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Email</label>
          <asp:TextBox ID="TxtEmail" runat="server" TextMode="Email"></asp:TextBox>
      </div>




      <div class="btn-register">
          <asp:Button ID="BApply" runat="server" Text="Apply" OnClick="BApply_Click"></asp:Button>
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