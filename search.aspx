﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="emppro.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 482px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <h4>Welcome&nbsp;
              <asp:Label ID="Label3" runat="server"></asp:Label>
          </h4>
     <div class="b"><a href="ResetPassword.aspx">Change Password</a>&nbsp;<a href="Loginpage.aspx">Logout</a><br /></div>
    <div class="a">
          <h4>Employee search</h4>
    <asp:Label ID="Label2" runat="server" Text="Search By"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="EmpId" Selected="False">Employee Id</asp:ListItem>
        <asp:ListItem Value="EmpName" Selected="False">Employee Name</asp:ListItem>
            </asp:DropDownList>
    <asp:Label ID="Label1" runat="server" Text="Contains"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        
       
          <br />
          <br />
        
       
        <asp:DataGrid ID="DataGrid1" runat="server"  Width="521px" CssClass="auto-style1" Height="158px" >

        </asp:DataGrid>
         </div>
          <br />
          <asp:Label ID="lblMsg" runat="server"></asp:Label>
        
          <br />
          <br />
   
          </asp:Content>
