<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_final._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <asp:Panel ID="Panel1" runat="server">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Agregar una cita"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Nit de paciente"></asp:Label>
                <asp:TextBox ID="txt_nit" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Fecha de cita"></asp:Label>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Hora de inicio"></asp:Label>
                <asp:TextBox ID="txt_inicio" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Hora de salida"></asp:Label>
                <asp:TextBox ID="txt_final" runat="server"></asp:TextBox>
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
                <br />
                <asp:Button ID="btn_agregarcita" runat="server" Text="Agregar" />
                <br />
                <asp:Button ID="btn_asistencia" runat="server" Text="Asistencia a cita" />
                <br />
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Cancelar cita" />
                        <br />
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:Panel ID="Panel2" runat="server" Height="59px">
                </asp:Panel>
            </asp:Panel>
        </div>
    </div>

</asp:Content>
