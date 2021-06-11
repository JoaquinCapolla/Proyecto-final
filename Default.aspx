<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_final._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <asp:Panel ID="Panel1" runat="server">
                <br />
                <asp:Panel ID="Panel5" runat="server">
                    <asp:Label ID="Label29" runat="server" BorderStyle="None" Font-Size="X-Large" Text="Ingrese a un modulo"></asp:Label>
                    <br />
                    <asp:Button ID="btn_administrativo" runat="server" OnClick="btn_administrativo_Click" Text="Modulo administrativo" />
                    <asp:Button ID="btn_medico" runat="server" OnClick="btn_medico_Click" Text="Modulo medico" />
                </asp:Panel>
                <br />
                <asp:Panel ID="Panel2" runat="server" style="margin-right: 0px">
                    <asp:Label ID="Label1" runat="server" Text="Agregar una cita" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Nit de paciente"></asp:Label>
                    <asp:TextBox ID="txt_nit" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Fecha de cita"></asp:Label>
                    <asp:Calendar ID="mont_fecha" runat="server"></asp:Calendar>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Hora de inicio"></asp:Label>
                    <asp:TextBox ID="txt_inicio" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Hora de salida"></asp:Label>
                    <asp:TextBox ID="txt_final" runat="server"></asp:TextBox>
                    <asp:GridView ID="Gridviewcitas" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <asp:Button ID="btn_agregarcita" runat="server" OnClick="btn_agregarcita_Click" Text="Agregar" />
                    <br />
                    <asp:Button ID="btn_asistencia" runat="server" OnClick="btn_asistencia_Click" Text="Asistencia a cita" />
                    <asp:Button ID="btn_cancelarcita" runat="server" OnClick="btn_cancelarcita_Click" Text="Cancelar cita" />
                </asp:Panel>
                <br />
                <asp:Panel ID="Panel3" runat="server">
                    <asp:Label ID="Label21" runat="server" Text="Consulta medica" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Nit del paciente"></asp:Label>
                    <asp:TextBox ID="txt_nitmed" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label9" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="txt_direccion" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Fecha de nacimiento"></asp:Label>
                    <asp:Calendar ID="calfechanaci" runat="server"></asp:Calendar>
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lbl_historial" runat="server" Text="Historial "></asp:Label>
                    <asp:GridView ID="Gridviewhistorial" runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="lbl_sintomas" runat="server" Text="Sintomas"></asp:Label>
                    <asp:GridView ID="Gridviewsintomas" runat="server">
                    </asp:GridView>
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="Consulta actual"></asp:Label>
                    <br />
                    <asp:Label ID="Label13" runat="server" Text="Temperatura"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label14" runat="server" Text="Presion"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label15" runat="server" Text="Sintomas"></asp:Label>
                    <asp:GridView ID="gridagregar_sintomas" runat="server">
                    </asp:GridView>
                    <asp:Button ID="btn_guardarsintoma" runat="server" OnClick="btn_guardarsintoma_Click" Text="Guardar sintoma" />
                    <br />
                    <br />
                    <asp:Label ID="Label16" runat="server" Text="Diagnostico"></asp:Label>
                    <br />
                    <asp:Label ID="Label17" runat="server" Text="Tratamiento"></asp:Label>
                    <asp:TextBox ID="txt_tratamiento" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label18" runat="server" Text="Receta"></asp:Label>
                    <asp:TextBox ID="txt_receta" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_guardarreceta" runat="server" OnClick="btn_guardarreceta_Click1" Text="Agregar Receta" />
                    <br />
                    <asp:Label ID="Label19" runat="server" Text="Proxima Visita"></asp:Label>
                    <asp:TextBox ID="txt_proximavisita" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label20" runat="server" Text="Costo de consulta"></asp:Label>
                    <asp:TextBox ID="txt_consulta" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_guardarconsulta" runat="server" OnClick="btn_guardarconsulta_Click1" Text="Guardar consulta" />
                </asp:Panel>
                <br />
                <asp:Panel ID="Panel4" runat="server">
                    <asp:Label ID="Label22" runat="server" Text="Agregar pacientes" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:Label ID="Label23" runat="server" Text="Nit del paciente"></asp:Label>
                    <asp:TextBox ID="txt_nitpaciente" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label24" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txt_nombre1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label25" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="txt_apellido1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label26" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="txt_direccion1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label27" runat="server" Text="Fecha de nacimiento"></asp:Label>
                    <asp:Calendar ID="calfechanaci1" runat="server"></asp:Calendar>
                    <br />
                    <asp:Label ID="Label28" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="txt_telefono1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_guardarpaciente" runat="server" OnClick="btn_guardarpaciente_Click" Text="Guardar" />
                    <br />
                    <br />
                </asp:Panel>
                <br />
            </asp:Panel>
        </div>
    </div>

</asp:Content>
