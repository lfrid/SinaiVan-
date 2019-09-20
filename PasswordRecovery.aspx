<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PasswordRecovery.aspx.cs" Inherits="PasswordRecovery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table id="Table1" align="center" cellspacing="2" cellpadding="5" width="50%" rules="none"
        border="0">
        <tr align="left">
            <td>
                <asp:PasswordRecovery ID="PassRecovery" runat="server" BackColor="#F7F6F3" BorderColor="Brown"
                    BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
                    Font-Size="1.2em" SuccessPageUrl="~/LogIn.aspx" OnSendingMail="PasswordRecovery_SendingMail">
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <SuccessTextStyle Font-Bold="True" ForeColor="#5D7B9D" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                    <SubmitButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                            Font-Names="Verdana" ForeColor="#284775" Font-Size="1.0em"/>
                    <MailDefinition BodyFileName="~/EmailTemplate/PasswordRecovery.txt" Subject="Your password has been reset..."
                        IsBodyHtml="true">
                    </MailDefinition>
                </asp:PasswordRecovery>
            </td>
        </tr>
    </table>
</asp:Content>

