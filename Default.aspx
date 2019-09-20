<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MasterPage.master"  CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    
    <script type="text/javascript">
        

        $(document).ready(function () {
            $("#trMenu").show();
        });


    </script>

</asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <div>
           <%-- <table id="Table1" align="center" cellspacing="2" cellpadding="5" width="30%" rules="none"
                border="0">
                <tr align="left">
                    <td>--%>
                       <%-- <fieldset class="divBorder">
                            <legend style="font-size:large ; font-weight:bold ; color:Black" >Employee Health Menu</legend>--%>
                           <%-- <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Disc" DisplayMode="LinkButton"
                                DataSourceID="XmlDataSource1" DataTextField="text" DataValueField="url" Font-Bold="True"
                                Font-Size="Medium" OnClick="BulletedList1_Click" OnDataBound="BulletedList1_DataBound">
                            </asp:BulletedList>--%>
                       <%-- </fieldset>--%>
                 <%--   </td>
                </tr>
            </table>--%>
            <center>
                <asp:Image ID="companyPicture" runat="server" />
            </center>
        </div>
      <%-- <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/ActiveForms.xml"></asp:XmlDataSource>--%>
    </asp:Content> 
 