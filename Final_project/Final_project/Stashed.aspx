<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stashed.aspx.cs" Inherits="Final_project.Stashed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Title -->
    <div class="jumbotron text-center default__title">
        <h3 class="default__title__typewriter">
            <asp:Label ID="LabelStashed" runat="server" Text=""></asp:Label></h3>
    </div>
    <!-- /Title -->

    <!-- List of favorite person -->
    <asp:GridView ID="StashList" runat="server"  AutoGenerateColumns="False" GridLines="Vertical" CellPadding="4"
        ItemType="Final_project.Models.FavoritePerson" SelectMethod="GetStashedFavoritePerson" 
        CssClass="table table-striped table-bordered">   
        <Columns> 
        <asp:BoundField DataField="DateCreated" HeaderText="Liked time" DataFormatString="{0:d}"/>
            <asp:TemplateField HeaderText="Profile">            
                <ItemTemplate>
                    <a class="btn btn-default stashed__button" href="/PersonDetails?personID=<%#:Item.PersonID %>">Profile</a>
                </ItemTemplate>        
        </asp:TemplateField>  
        <asp:BoundField DataField="Person.PersonName" HeaderText="Name" />        
        <asp:BoundField DataField="Person.PersonSurname" HeaderText="Surname" />
        <asp:BoundField DataField="Person.PersonAge" HeaderText="Age" />
        <asp:BoundField DataField="Person.PersonHeight" HeaderText="Height" />
        <asp:BoundField DataField="Person.Gender.GenderName" HeaderText="Gender" />
        <asp:TemplateField HeaderText="Remove from list">
            <ItemTemplate>
                <a class="btn btn-default stashed__button" href="/RemoveFromStash.aspx?personID=<%#:Item.PersonID %>&stashedFavoriteID=<%#:Item.StashedFavoriteID %>">Remove</a>
            </ItemTemplate>
        </asp:TemplateField>    
        </Columns>    
    </asp:GridView>
    <!-- /List of favorite person -->
</asp:Content>
