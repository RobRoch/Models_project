<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonDetails.aspx.cs" Inherits="Final_project.PersonDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Person details - used GetPerson() method to achieve data -->
    <asp:FormView ID="personDetail" runat="server" ItemType="Final_project.Models.Person" SelectMethod="GetPerson" RenderOuterTable="false">
        <ItemTemplate>
            <div class="container-fluid">
                <!-- Card -->
                <div class="card">
                    <div class="row personDetails__row">
                        <!-- Card Photo -->
                        <div class="col-md-6">
                            <div class="card-img-bottom img-thumbnail personDetails__image" style="background: url(Catalog/Images/<%#:Item.ImagePath%>) center no-repeat"></div>
                        </div>
                        <!-- /Card Photo -->
                        <!-- Card Text -->
                        <div class="col-md-6">
                            <h2 class="card-title text-center personDetails__title"><%#:Item.PersonName %> <%#:Item.PersonSurname %></h2>
                            <div class="card-text">
                                <div class="row text-center">
                                    <!-- Person data -->
                                    <div class="col-xs-6">
                                        <h3>
                                            Age: <%#:Item.PersonAge %>
                                        </h3>
                                    </div>
                                    <div class="col-xs-6">
                                        <h3>
                                            Height: <%#:Item.PersonHeight %>
                                        </h3>
                                    </div>
                                    <div class="col-xs-6">
                                        <h3>
                                            Weight: <%#:Item.PersonWeight %>
                                        </h3>
                                    </div>
                                    <div class="col-xs-6">
                                        <h3>
                                            Leg length: <%#:Item.PersonLegLength %>
                                        </h3>
                                    </div>
                                    <div class="col-xs-6">
                                        <h3>
                                            Shoe size: <%#:Item.PersonShoeSize %>
                                        </h3>
                                    </div>
                                    <div class="col-xs-6">
                                        <h3>
                                            Gender: <%#:Item.Gender.GenderName %>
                                        </h3>
                                    </div>
                                    <!-- /Person data -->
                                    <!-- Navigation to person list -->
                                    <div class="col-xs-6">
                                        <h3>
                                            <a class="personDetails__favorite" href="/Person.aspx">
                                                <b>Go back!</b>
                                            </a>
                                        </h3>
                                    </div>
                                    <!-- /Navigation to person list -->
                                    <!-- Adding favorite to stash -->
                                    <div class="col-xs-6">
                                        <h3>
                                            <a class="personDetails__favorite" href="/AddToStash.aspx?personID=<%#:Item.PersonID %>">
                                                <b>Add to my favorites!</b>
                                            </a>
                                        </h3>
                                    </div>
                                     <!-- /Adding favorite to stash -->
                                </div>
                            </div>
                        </div>
                        <!-- /Card Text -->
                    </div>
                </div>
                <!-- /Card -->
            </div>
        </ItemTemplate>
    </asp:FormView>
    <!-- End of person details -->
</asp:Content>
