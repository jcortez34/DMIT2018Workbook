<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Neighborhood</h2>
            <asp:GridView runat="server" ID="PeopleGridView" AutoGenerateColumns="false" DataSourceID="DemoDataSource">
                <Columns>
                    <asp:BoundField DataField="PersonID" HeaderText="PersonID" ReadOnly="True" SortExpression="PersonID"></asp:BoundField>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" ReadOnly="True" SortExpression="FirstName"></asp:BoundField>
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" ReadOnly="True" SortExpression="LastName"></asp:BoundField>
                    <asp:BoundField DataField="BirthDate" HeaderText="Birth Date" ReadOnly="True" SortExpression="BirthDate"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource runat="server" ID="DemoDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListPeople" TypeName="DemoSystem.BLL.DemoContoller"></asp:ObjectDataSource>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
