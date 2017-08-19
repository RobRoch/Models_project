<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="Final_project.Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Title with navigation -->
    <div class="jumbotron text-center default__title">
        <h2>
            Registered models
        </h2>
        <h3 class="default__title__navbar">
            <!-- Used ListView and GetGenders() method to make a list of genderName from db -->
            <asp:ListView ID="genderList"
                ItemType="Final_project.Models.Gender"
                runat="server"
                SelectMethod="GetGenders">
                <ItemTemplate>
                    <span>
                        <a href="/Person.aspx?id=<%#: Item.GenderID %>">
                            <%#: Item.GenderName %>
                        </a>
                    </span>
                </ItemTemplate>
                <ItemSeparatorTemplate> || </ItemSeparatorTemplate>
            </asp:ListView>
            <!-- Adding additional genderName that get's everybody again -->
            <span> || </span>
            <span>
                <a href="/Person.aspx">All</a>
            </span>
        </h3>
    </div>
    <!-- End of title -->

    <!-- Person list -->
    <div class="container-fluid">
        <div id="PersonMenu" class="row person__row">
            <!-- Again ListView and GetPersons() method to get all persons from db. -->
            <asp:ListView ID="personList"
                DataKeyNames="PersonID"
                ItemType="Final_project.Models.Person"
                runat="server"
                SelectMethod="GetPersons">
                <ItemTemplate runat="server">
                    <a href="PersonDetails.aspx?personID=<%#:Item.PersonID%>">
                        <div class="card person__row__card col-md-3 col-xs-4">
                            <img class="card-img-top img-thumbnail person__card__image" src="/Catalog/Images/<%#:Item.ImagePath%>" alt="Card image cap">
                            <!-- Show while hover -->
                            <div class="card-block text-center person__card__text">
                                <h3 class="text"><%#:Item.PersonName %></h3>
                                <h3 class="text"><%#:Item.PersonSurname %></h3>
                                <h3 class="text">Age: <%#:Item.PersonAge %></h3>
                            </div>
                        </div>
                    </a>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
    <!-- End of person list -->
</asp:Content>
