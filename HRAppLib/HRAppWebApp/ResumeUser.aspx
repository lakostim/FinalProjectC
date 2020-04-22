<%@ Page Language="C#" MasterPageFile="~/MasterContent/ApplicantWeb.Master" AutoEventWireup="true" CodeBehind="ResumeUser.aspx.cs" Inherits="HRAppWebApp.ResumeUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="resume-container">
  <h3>Create or Modify your Resume</h3>
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
          <label>Experience</label>
          <asp:TextBox ID="TxtExperience" runat="server" TextMode="Number"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Skills</label>
          <asp:TextBox ID="TxtSkills" runat="server"></asp:TextBox>
      </div>

      <div class="input-box">
          <label>Email</label>
          <asp:TextBox ID="TxtEmail" runat="server" TextMode="Email"></asp:TextBox>
      </div>

    <div class="input-box">
          <label>Phone</label>
          <asp:TextBox ID="TxtPhone" runat="server" TextMode="Number"></asp:TextBox>
      </div>

      <div class="btn-register">
          <asp:Button ID="BApply" runat="server" Text="Update"></asp:Button>
      </div>
      
  </div>

    <style>
        .resume-container{
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