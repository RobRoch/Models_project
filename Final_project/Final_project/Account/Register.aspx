<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Final_project.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <!-- Title register -->
    <div class="jumbotron text-center default__title">
        <h3>Registration form</h3>
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div>
            <h4 class="default__title__typewriter">Create a new account easily</h4>
        </div>
    </div>
    <!-- Title ends -->

    <!-- Register form -->
    <div class="container-fluid">
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="row register__row">

            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-4 text-right control-label">Email:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>

            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-4 text-right control-label">Password:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>

            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-4 text-right control-label">Confirm password:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
            <hr />
            <div class="col-md-12 text-center register__submit">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default register__submit__button" />
            </div>
        </div>
    </div>
    <!-- Register form end -->
</asp:Content>
