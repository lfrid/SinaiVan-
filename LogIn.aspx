<%@ Page Title="LogIn" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="Forms_LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        window.onload = function () {
            SetWindow_Size();
        }

        function SetWindow_Size() {
            try {
                top.window.moveTo(0, 0);
                top.window.resizeTo(screen.availWidth, screen.availHeight);
            }
            catch (Error) {
            }
        }

        $(document).ready(function () {
            $("#trMenu").hide();

            //var $img = $("#tblFrame img");
            //$img.each(function() {
            //    var src = this.src; //.replace("~/", "");
            //})
        });

    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <div>
            <table id="Table1" cellspacing="5" cellpadding="5" class="largeText"
                style="margin-top: 25px;">
                <tr>
                    <td class="Center">
                        <asp:Login ID="Login1" runat="server" BorderPadding="4" BorderStyle="Solid"
                            BorderWidth="1px" BorderColor="Brown" DestinationPageUrl="~/Forms/WorkTime.aspx"
                            TextBoxStyle-CssClass="logInTextBox"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" DisplayRememberMe="False"
                            PasswordRecoveryText="Forget Your password?"
                            PasswordRecoveryUrl="~/PasswordRecovery.aspx" OnAuthenticate="Login1_Authenticate">
                            <%-- <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                                    <TextBoxStyle Font-Size="0.9em" />
                                    <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                                        Font-Names="Verdana" ForeColor="#284775" Font-Size="1.0em" />
                                    <CheckBoxStyle Width="0px" />--%>
                        </asp:Login>
                    </td>
                </tr>
                <%-- <tr>
                            <td>Do not have account yet?<br />
                                <asp:LinkButton ID="linkNewUser" runat="server" Text="Click here to create one now!" PostBackUrl="~/AdminOnly/RegisterUser.aspx"></asp:LinkButton>
                              <br />
                                <asp:LinkButton ID="LinkNewRole" runat="server" Text="Click here to create User to Roles" PostBackUrl="~/AdminOnly/UserToRole.aspx"></asp:LinkButton>
                            </td>
                        </tr>--%>
            </table>
        </div>
    </center>
</asp:Content>

