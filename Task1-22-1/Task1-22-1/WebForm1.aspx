<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task1_22_1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="input-group mb-3">

    <label class="input-group-text" style="width:100px"> Name: </label>
    <asp:TextBox class="form-control" placeholder="Username" ID="Name" runat="server"></asp:TextBox>
        </div>
     <div class="input-group mb-3">
     <label class="input-group-text" style="width:100px" > Age: </label>
    <asp:TextBox class="form-control" placeholder="Username" ID="Age" runat="server"></asp:TextBox>
         </div>
         <div class="input-group mb-3">

     <label class="input-group-text" style="width:100px"> Phone: </label>
    <asp:TextBox class="form-control" placeholder="Username" ID="Phone" runat="server"></asp:TextBox>
             </div>
             <div class="input-group mb-3">

    <label class="input-group-text" style="width:100px"> Email: </label>
    <asp:TextBox class="form-control" placeholder="Username" ID="Email" runat="server"></asp:TextBox>
                              </div>

    <asp:FileUpload class="form-control" ID="userImage" runat="server" />
    <br />
    <label> City: </label>
    <asp:DropDownList class="btn btn-secondary" ID="CityList" runat="server"></asp:DropDownList>
    <br />
    <asp:Button  class="btn btn-primary" style="float:right" OnClick="AddUser" ID="Button1" runat="server" Text="Add user" />
</asp:Content>

