<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Final_project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Title -->
    <div class="jumbotron text-center default__title">
        <h2>MODELS</h2>
        <h3 class="default__title__typewriter">MEET OUR MODELS</h3>
    </div>
    <!-- End of title -->

    <!-- Additional informaction -->
    <div class="container-fluid">
        <div class="row default__row">
            <div class="col-sm-6 col-xs-12 default__row__section">
                <h3 class="text-center">Are you a Model?</h3>
                <p>Want to start your modeling career? Excellently! We know how to help you achieve this!</p>
                <p>You don't need to have experience to be a model. 
                   We are looking for interesting faces and personalities, regardless of experience or place of residence.</p>
                <p>All you have to do is ask someone to take your picture. Follow the instructions and we will take care of the rest.</p>
                <p>Ready to take the first step?</p>
                <p class="text-center">
                    <a class="btn btn-default default__row__button" href="/JoinUs.aspx">Sign up!</a>
                </p>
            </div>
            <div class="col-sm-6 col-xs-12 default__row__section">
                <h2 class="text-center">Want to keep an eye on your favorite models?</h2>
                <p>You can easily register on our website.</p>
                <p>After a quick registration, you can save your favorites and check them later!</p>
                <p>It's pretty simple isn't it?</p>
                <p>Don't miss another minute, just come get along!</p>
                <p class="text-center">
                    <a class="btn btn-default default__row__button" href="/Account/Register.aspx">Register!</a>
                </p>
            </div>
        </div>
    </div>
    <!-- End of additional informaction -->

</asp:Content>
