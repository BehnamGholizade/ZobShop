﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ZobShop.Web.Product.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:FormView runat="server" ID="DetailsView" AutoGenerateRows="false">
        <ItemTemplate>
            <div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
