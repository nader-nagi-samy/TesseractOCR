<%@ Page Title="" Language="C#" MasterPageFile="~/Parent.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDemo.Views.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="inputPanel" runat="server">
        <fieldset>
            <legend>File Upload</legend>
            <div class="form-group">
                <asp:Label ID="Label1" AssociatedControlID="ImageFile" runat="server" Text="File:"></asp:Label>
                <asp:FileUpload ID="ImageFile" runat="server" CssClass="form-control" />
            </div>
            <br />
            <asp:Button ID="SubmitFile" runat="server" Text="Submit" CssClass="btn btn-primary"
                OnClick="SubmitFile_Click" />
        </fieldset>
    </asp:Panel>
    <hr />
    <asp:Panel ID="resultPanel" Visible="false" runat="server">
        <fieldset>
            <legend>OCR Results</legend>
            <div class="form-group">
                <asp:Label ID="Label2" AssociatedControlID="ConfidenceLabel" runat="server" Text="Confidence:"></asp:Label>
                <asp:Label ID="ConfidenceLabel" runat="server" CssClass="form-control"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" AssociatedControlID="ResultText" runat="server" Text="Result:"></asp:Label>
                <textarea class="form-control" rows="10" id="ResultText" readonly="readonly" runat="server"></textarea>
                <%--<asp:TextBox ID="ResultText" runat="server" TextMode="MultiLine" ReadOnly="true" Rows="10" CssClass="form-control"></asp:TextBox>--%>
            </div>
            <br />
            <asp:Button ID="ReSubmitFile" runat="server" Text="UploadAgain" CssClass="btn btn-info"
                OnClick="ReSubmitFile_Click" />
        </fieldset>
    </asp:Panel>

</asp:Content>
