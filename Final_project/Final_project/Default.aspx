<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Final_project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Title -->
    <div class="jumbotron text-center default__title">
        <h2>MODELS</h2>
        <h3 class="default__title__typewriter">MEET OUR MODELS</h3>
    </div>
    <!-- /Title -->

    <!-- Additional informaction -->
    <div class="container-fluid">
        <div class="row default__row">
            <!-- Section join us -->
            <div class="col-sm-6 col-xs-12 default__row__section">
                <h3 class="text-center">Are you a Model?</h3>
                <p>Want to start your modeling career? Excellently! We know how to help you achieve this!</p>
                <p>you don't need to have experience to be a model. 
                   we are looking for interesting faces and personalities, regardless of experience or place of residence.</p>
                <p>all you have to do is ask someone to take your picture. follow the instructions and we will take care of the rest.</p>
                <p>ready to take the first step?</p>
                <p class="text-center">
                    <a class="btn btn-default default__row__button" href="/JoinUs.aspx">Sign up!</a>
                </p>
            </div>
            <!-- /Section join us -->
            <!-- Section register -->
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
            <!-- /Section register -->
        </div>
    </div>
    <!-- /Additional informaction -->

</asp:Content>
