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
                    <asp:Button ID="btn_medico" runat="server" OnClick="btn_medico_Click" Text="Modulo medico" Width="203px" />
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
                    <asp:TextBox ID="txt_apellido" runat="server" OnTextChanged="txt_apellido_TextChanged"></asp:TextBox>
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
                    <asp:Panel ID="Panel6" runat="server">
                        <br />
                        <asp:Label ID="lbl_historial" runat="server" Text="Historial "></asp:Label>
                        <asp:GridView ID="Gridviewhistorial" runat="server" OnSelectedIndexChanged="Gridviewhistorial_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>
                        <asp:Label ID="lbl_sintomas" runat="server" Text="Sintomas"></asp:Label>
                        <asp:GridView ID="Gridviewsintomas" runat="server" OnSelectedIndexChanged="Gridviewsintomas_SelectedIndexChanged">
                        </asp:GridView>
                    </asp:Panel>
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="Consulta actual" Font-Size="X-Large" ForeColor="#FF3300"></asp:Label>
                    <br />
                    <asp:Label ID="Label13" runat="server" Text="Temperatura"></asp:Label>
                    <asp:TextBox ID="txt_temperatua" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label14" runat="server" Text="Presion"></asp:Label>
                    <asp:TextBox ID="txt_presion" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label15" runat="server" Text="Sintomas"></asp:Label>
                    <asp:GridView ID="listadesintomas" runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:Button ID="btn_guardarsintoma" runat="server" OnClick="btn_guardarsintoma_Click" Text="Guardar sintoma" />
                    <br />
                    <asp:Label ID="Label16" runat="server" Text="Diagnostico"></asp:Label>
                    <asp:TextBox ID="txt_diagnostico" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label17" runat="server" Text="Tratamiento"></asp:Label>
                    <asp:GridView ID="gridtratamiento" runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
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
                <asp:Panel ID="Panel7" runat="server">
                    <asp:Label ID="Label30" runat="server" Font-Size="X-Large" ForeColor="Red" Text="Agregar sintomas"></asp:Label>
                    <br />
                    <asp:Label ID="Label45" runat="server" Text="Codigo de sintoma"></asp:Label>
                    <asp:TextBox ID="txt_codsintoma" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label32" runat="server" Text="Sintoma"></asp:Label>
                    <asp:TextBox ID="txt_ingresosintoma" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_agregarsintoma" runat="server" OnClick="btn_agregarsintoma_Click" Text="Agregar sintoma" />
                    <br />
                    <asp:Label ID="Label44" runat="server" Font-Size="Large" ForeColor="Blue" Text="Editar sintomas"></asp:Label>
                    <br />
                    <asp:Label ID="Label46" runat="server" Text="Buscar por codigo"></asp:Label>
                    <asp:TextBox ID="txt_buscarsintoma" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_buscarsintoma" runat="server" OnClick="btn_buscarsintoma_Click" Text="Buscar" />
                    <br />
                    <asp:Label ID="Label47" runat="server" Text="Sintoma"></asp:Label>
                    <asp:TextBox ID="txt_editsintoma" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_guardarcambiosintoma" runat="server" OnClick="btn_guardarcambiosintoma_Click" Text="Guardar cambios" />
                    <asp:Button ID="btn_eliminarsintoma" runat="server" OnClick="btn_eliminarsintoma_Click" Text="Eliminar Sintoma" />
                    <br />
                </asp:Panel>
                <br />
                <br />
                <asp:Panel ID="Panel8" runat="server">
                    <asp:Label ID="Label33" runat="server" Font-Size="X-Large" ForeColor="Red" Text="Agregar medicamentos"></asp:Label>
                    <br />
                    <asp:Label ID="Label34" runat="server" Text="Enfermedades "></asp:Label>
                    <asp:TextBox ID="txt_enfermedades" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_agregarenfer" runat="server" OnClick="btn_agregarenfer_Click" Text="Agregar" />
                    <br />
                    <asp:Label ID="Label35" runat="server" Text="Codigo del medicamento"></asp:Label>
                    <asp:TextBox ID="txt_codmedicamentos" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label36" runat="server" Text="Ingrediente generico"></asp:Label>
                    <asp:TextBox ID="txt_ingredientegen" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label37" runat="server" Text="Laboratorio"></asp:Label>
                    <asp:TextBox ID="txt_laboratorio" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_guardarmed" runat="server" OnClick="btn_guardarmed_Click" Text="Guardar medicamento" />
                    <br />
                    <br />
                    <asp:Label ID="Label43" runat="server" Font-Size="Large" ForeColor="Blue" Text="Editar medicamentos"></asp:Label>
                    <br />
                    <asp:Label ID="Label38" runat="server" Text="Buscar por codigo"></asp:Label>
                    <asp:TextBox ID="txt_codigo" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_buscarcodigo" runat="server" OnClick="btn_buscarcodigo_Click" Text="Buscar" />
                    <br />
                    <asp:Label ID="Label39" runat="server" Text="Enfermedades"></asp:Label>
                    <asp:TextBox ID="txt_edienfermedades" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_editarenfermedad" runat="server" OnClick="btn_editarenfermedad_Click" Text="Agregar" />
                    <asp:GridView ID="grid_editmedicamentos" runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:Button ID="btn_eliminarenfermedad" runat="server" OnClick="btn_eliminarenfermedad_Click" Text="Eliminar enfermedad" />
                    <br />
                    <asp:Label ID="Label41" runat="server" Text="Ingrediente generico"></asp:Label>
                    <asp:TextBox ID="txt_editingrediente" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label42" runat="server" Text="Laboratorio"></asp:Label>
                    <asp:TextBox ID="txt_editlaboratorio" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_guardareditarmedi" runat="server" OnClick="btn_guardareditarmedi_Click" Text="Guardar cambios" />
                    <asp:Button ID="btn_eliminaredit" runat="server" Text="Eliminar medicamentos" />
                    <br />
                    <br />
                </asp:Panel>
                <br />
                <br />
                <asp:Panel ID="Panel9" runat="server">
                    <asp:Label ID="Label49" runat="server" Font-Size="X-Large" ForeColor="Red" Text="Buscar historial"></asp:Label>
                    <br />
                    <asp:Label ID="Label48" runat="server" Text="Buscar paciente"></asp:Label>
                    <asp:TextBox ID="txt_buscarhistorial" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_buscarhistorial" runat="server" OnClick="btn_buscarhistorial_Click" Text="Buscar" />
                    <br />
                    <asp:Label ID="Label50" runat="server" Text="Cantidad de historiales:  "></asp:Label>
                    <asp:TextBox ID="txt_histocant" runat="server"></asp:TextBox>
                    <br />
                    <asp:GridView ID="gridmuestrahistorial" runat="server">
                    </asp:GridView>
                </asp:Panel>
                <br />
                <br />
                <asp:Panel ID="Panel10" runat="server">
                    <br />
                    <asp:Label ID="Label51" runat="server" Font-Size="X-Large" ForeColor="Red" Text="Reporte de pacientes "></asp:Label>
                    <br />
                    <asp:Label ID="Label52" runat="server" Text="Cantidad de citas canceladas"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label53" runat="server" Text="Cantidad de citas asistidas"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    <br />
                </asp:Panel>
                <br />
                <br />
            </asp:Panel>
        </div>
    </div>

</asp:Content>
