<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JoinUs.aspx.cs" Inherits="Final_project.JoinUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Title -->
    <div class="jumbotron text-center default__title">
        <h3 class="default__title__typewriter">Fill out the survey and join us!</h3>
    </div>
    <!-- End of title -->

    <!-- Adding person form -->
    <div class="container-fluid">
        <div class="row joinUs__row">
            <div class="col-md-3 col-xs-6">
                <h4>Name:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:TextBox ID="AddPersonName" class="joinUs__data" runat="server" autocomplete="off" ></asp:TextBox>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Surname:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:TextBox ID="AddPersonSurname" class="joinUs__data" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Age:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:TextBox ID="AddPersonAge" class="joinUs__data" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Height:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:TextBox ID="AddPersonHeight" class="joinUs__data" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Weight:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:TextBox ID="AddPersonWeight" class="joinUs__data" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Leg length:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:TextBox ID="AddPersonLegLength" class="joinUs__data" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Shoe size:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:DropDownList ID="AddPersonShoeSize" class="joinUs__data" runat="server">
                    <asp:ListItem Value="4" Selected="True">4</asp:ListItem>
                    <asp:ListItem Value="5">5</asp:ListItem>
                    <asp:ListItem Value="6">6</asp:ListItem>
                    <asp:ListItem Value="7">7</asp:ListItem>
                    <asp:ListItem Value="8">8</asp:ListItem>
                    <asp:ListItem Value="9">9</asp:ListItem>
                    <asp:ListItem Value="10">10</asp:ListItem>
                    <asp:ListItem Value="11">11</asp:ListItem>
                    <asp:ListItem Value="12">12</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Gender:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:DropDownList ID="AddPersonGender" class="joinUs__data" runat="server"
                    ItemType="Final_project.Models.Gender"
                    SelectMethod="GetGender" DataTextField="GenderName"
                    DataValueField="GenderID">
                </asp:DropDownList>
            </div>
            <div class="col-md-3 col-xs-6">
                <h4>Photo:</h4>
            </div>
            <div class="col-md-3 col-xs-6">
                <asp:FileUpload class="joinUs__data" ID="AddPersonImage" runat="server" />
            </div>
        </div>
        <br />
        <div class="row joinUs__row text-center">
            <!-- validating using custom validator -->
            <div class="col-xs-12">
                <h4>
                    <asp:CustomValidator ID="joinUsValidator" OnServerValidate="FormValidation" runat="server" Text="">
                    </asp:CustomValidator>
                </h4>
            </div>
            <!--gives status of submit-->
            <div class="col-xs-12">
                <h4>
                    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
                </h4>
            </div>
            <div class="col-xs-12">
                <h4>
                    <asp:Button class="btn btn-default joinUs__button" ID="AddPersonButton" runat="server" Text="Submit" CausesValidation="true" OnClick="AddPersonButton_click" />
                </h4>
            </div>
        </div>
    </div>
    <!-- End of person form -->

</asp:Content>
