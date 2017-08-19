<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Final_project.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <!-- Title register -->
    <div class="jumbotron text-center default__title">
        <h3>Log in</h3>
        <p class="text-danger">
            <asp:Literal runat="server" ID="Literal1" />
        </p>
        <div>
            <h4 class="default__title__typewriter">Use your registered account</h4>
        </div>
    </div>
    <!-- Title ends -->

    <!-- Logging form -->
    <div class="container-fluid">
    <div class="row register__row">
        <div class="col-md-12">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4 class="text-center">Use your account to log in.</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-4 control-label">Email:</asp:Label>
                        <div class="col-md-8">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="text-danger" ErrorMessage="The email field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-4 control-label">Password:</asp:Label>
                        <div class="col-md-8">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="text-center col-md-12">
                            <div class="checkbox">
                                <asp:CheckBox runat="server" ID="RememberMe" />
                                <asp:Label runat="server" AssociatedControlID="RememberMe">Remember me?</asp:Label>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="text-center col-md-12 register__submit">
                            <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-default register__submit__button" />
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
        </div>
    <!-- Logging form end -->
</asp:Content>
