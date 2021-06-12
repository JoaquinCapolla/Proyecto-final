using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Proyecto_final
{
    public partial class _Default : Page
    {
        static List<Agenda> agenda = new List<Agenda>();
        static List<Citas> citas = new List<Citas>();
        static List<Tratamiento> tratamiento = new List<Tratamiento>();
        static List<Sintomas> sintomas = new List<Sintomas>();
        static List<Histo> histo= new List<Histo>();
        static List<Pacientes> pacientes = new List<Pacientes>();
        static List<Historial> historial = new List<Historial>();
        static List<Medicamentos> medicamentos = new List<Medicamentos>();
        static List<Sintomasagregados> sintom= new List<Sintomasagregados>();
        static List<Enfermedades> enfermedades= new List<Enfermedades>();
        static List<Cantidad> cantidad = new List<Cantidad>();
        static List<Momentanea> momentanea = new List<Momentanea>();
        void Cargaragenda() 
        {
            string archivo = Server.MapPath("Agenda.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (string.IsNullOrEmpty(json))
                {

                }
                else
                {
                    agenda = JsonConvert.DeserializeObject<List<Agenda>>(json);
                }
            }
        }
        void Cargarmomentanea()
        {
            string archivo = Server.MapPath("momentanea.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (string.IsNullOrEmpty(json))
                {

                }
                else
                {
                    momentanea = JsonConvert.DeserializeObject<List<Momentanea>>(json);
                }
            }
        }
        void Cargarcitas()
        {
            string archivo = Server.MapPath("Citas.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (string.IsNullOrEmpty(json))
                {
                    
                }
                else
                {
                    citas = JsonConvert.DeserializeObject<List<Citas>>(json);
                }
            }
        }
        void Cargarhistorial()
        {
            string archivo = Server.MapPath("Historial.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (string.IsNullOrEmpty(json))
                {

                }
                else
                {
                    historial = JsonConvert.DeserializeObject<List<Historial>>(json);
                }
            }
        }
        void Cargarpacientes()
        {
            string archivo = Server.MapPath("Pacientes.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (string.IsNullOrEmpty(json))
                {
                   
                }
                else
                {
                    pacientes = JsonConvert.DeserializeObject<List<Pacientes>>(json);
                }
            }
        }
        void Cargarmedicamentos()
        {
            string archivo = Server.MapPath("Medicamentos.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (string.IsNullOrEmpty(json))
                {

                }
                else
                {
                    medicamentos = JsonConvert.DeserializeObject<List<Medicamentos>>(json);
                }
            }
        }
        void Cargarsintomasagregados()
        {
            string archivo = Server.MapPath("Sintomasagregados.json");
            if (File.Exists(archivo))
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (string.IsNullOrEmpty(json))
                {

                }
                else
                {
                    sintom = JsonConvert.DeserializeObject<List<Sintomasagregados>>(json);
                }
            }
        }
        private void GuardarCitas()
        {
            string json = JsonConvert.SerializeObject(citas);
            string archivo = Server.MapPath("Citas.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        private void GuardarAgenda()
        {
            string json = JsonConvert.SerializeObject(agenda);
            string archivo = Server.MapPath("Agenda.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        private void Guardarmomentanea()
        {
            string json = JsonConvert.SerializeObject(momentanea);
            string archivo = Server.MapPath("momentanea.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        private void Guardarhistorial()
        {
            string json = JsonConvert.SerializeObject(historial);
            string archivo = Server.MapPath("Historial.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        private void Guardarpacientes()
        {
            string json = JsonConvert.SerializeObject(pacientes);
            string archivo = Server.MapPath("Pacientes.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        private void Guardarmedicamentos()
        {
            string json = JsonConvert.SerializeObject(medicamentos);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        private void Guardarsintomasagregados()
        {
            string json = JsonConvert.SerializeObject(sintom);
            string archivo = Server.MapPath("Sintomasagregados.json");
            System.IO.File.WriteAllText(archivo, json);

        }
        void mostrarcitas()
        {
            Gridviewcitas.DataSource = agenda;
            Gridviewcitas.DataBind();
        }
        void mostrarhistorial()
        {
            Gridviewcitas.DataSource = historial;
            Gridviewcitas.DataBind();
        }
        void mostrarsintomasmedico()
        {
            listadesintomas.DataSource = sintom;
            listadesintomas.DataBind();
        }
        void mostrartratamientos()
        {
            gridtratamiento.DataSource = medicamentos;
            gridtratamiento.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Cargaragenda();
            Cargarcitas();
            Cargarhistorial();
            Cargarpacientes();
            Cargarmedicamentos();
            Cargarsintomasagregados();
            Cargarmedicamentos();
            mostrarcitas();
            mostrarsintomasmedico();
            mostrartratamientos();
            if (momentanea.Count < 1)
            {
                Cargarmomentanea();
            }
        }
        
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        protected void btn_agregarcita_Click(object sender, EventArgs e)
        {
            Agenda agendatemp = new Agenda();
            agendatemp.Nit_paciente = txt_nit.Text;
            agendatemp.Hora_inicio = txt_inicio.Text;
            agendatemp.Hora_fin = txt_final.Text;
            agendatemp.Fecha = mont_fecha.SelectedDate;
            agenda.Add(agendatemp);
            mostrarcitas();
            GuardarAgenda();
        }

        protected void btn_asistencia_Click(object sender, EventArgs e)
        {
            Citas citastemp = new Citas();
            int indice = Gridviewcitas.SelectedIndex;
            citastemp.Nit_paciente = agenda[indice].Nit_paciente;
            citastemp.Fecha = agenda[indice].Fecha;
            citastemp.Hora_inicio = agenda[indice].Hora_inicio;
            citastemp.Hora_fin = agenda[indice].Hora_fin;
            citastemp.Asistencia = 1;
            momentanea[0].Fechaconsulta1 = agenda[indice].Fecha;
            momentanea[0].Horadeconsulta = agenda[indice].Hora_inicio;
            citas.Add(citastemp);
            int va= 0;
            for (int x = 0; x < pacientes.Count; x++)
            {
                if (agenda[indice].Nit_paciente.CompareTo(pacientes[x].Nit_Paciente1) == 0)
                {
                    MessageBox.Show("El paciente ya estaba registrado no ingrese datos");
                    va = va+1;
                    momentanea[0].Posi = x;
                    txt_nitmed.Text= pacientes[momentanea[0].Posi].Nit_Paciente1;
                    txt_nombre.Text = pacientes[momentanea[0].Posi].Nombre;
                    txt_apellido.Text = pacientes[momentanea[0].Posi].Apellido;
                    txt_direccion.Text = pacientes[momentanea[0].Posi].Direccion;
                    calfechanaci.SelectedDate = pacientes[momentanea[0].Posi].Fecha_nacimiento1;
                    txt_telefono.Text = pacientes[momentanea[0].Posi].Telefono;
                    txt_nitmed.Enabled = false;
                    txt_nombre.Enabled = false;
                    txt_apellido.Enabled = false;
                    txt_direccion.Enabled = false;
                    calfechanaci.Enabled = false;
                    txt_telefono.Enabled = false;
                    momentanea[0].Existpaciente = 1;
                    break;
                }
            }
            int his = 0;
            for (int x = 0; x < historial.Count; x++)
            {
                if (pacientes[momentanea[0].Posi].Nit_Paciente1.CompareTo(historial[x].Nit_paciente) == 0)
                {
                    his++;
                    momentanea[0].Posihis = x;
                    momentanea[0].Existhistorial = 1; 
                }
            }
            if(his == 0)
            {
                MessageBox.Show("El paciente no tiene historial medico");
                Panel6.Visible = false;
            }
            else
            {
                Panel6.Visible = true;
                Gridviewhistorial.DataSource = historial[momentanea[0].Posihis].Cantidad[0].Histo;
                Gridviewhistorial.DataBind();

            }
            if (va == 0)
            {
                MessageBox.Show("El paciente es nuevo, ingrese los datos");
                txt_nitmed.Text = agenda[indice].Nit_paciente;
            }
            agenda.RemoveAt(indice);
            Panel3.Visible = true;
            Panel2.Visible = false;
            mostrarcitas();
            GuardarCitas();
            GuardarAgenda();
            txt_nit.Text = "";
            txt_inicio.Text = "";
            txt_final.Text = "";
        }

        protected void btn_cancelarcita_Click(object sender, EventArgs e)
        {
            Citas citastemp = new Citas();
            int indice = Gridviewcitas.SelectedIndex;
            citastemp.Nit_paciente = agenda[indice].Nit_paciente;
            citastemp.Fecha = agenda[indice].Fecha;
            citastemp.Hora_inicio = agenda[indice].Hora_inicio;
            citastemp.Hora_fin = agenda[indice].Hora_fin;
            citastemp.Asistencia = 0;
            citas.Add(citastemp);
            agenda.RemoveAt(indice);
            mostrarcitas();
            GuardarCitas();
            GuardarAgenda();
            txt_nit.Text = "";
            txt_inicio.Text = "";
            txt_final.Text = "";
        }

        protected void btn_administrativo_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            Panel2.Visible = false;
            Panel7.Visible = true;
            Panel8.Visible = true;
        }

        protected void btn_medico_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel3.Visible = true;
            Panel4.Visible = false;
        }

        protected void btn_guardarpaciente_Click(object sender, EventArgs e)
        {
            int cons = 0;
            for (int x=0;x<pacientes.Count;x++)
            {
                if(txt_nitpaciente.Text.CompareTo(pacientes[x].Nit_Paciente1) == 0)
                {
                    cons++;
                    break;
                }
            }
            if (cons == 0)
            {
                Pacientes pacientestemp = new Pacientes();
                pacientestemp.Nit_Paciente1 = txt_nitpaciente.Text;
                pacientestemp.Nombre = txt_nombre1.Text;
                pacientestemp.Apellido = txt_apellido1.Text;
                pacientestemp.Direccion = txt_direccion1.Text;
                pacientestemp.Fecha_nacimiento1 = calfechanaci1.SelectedDate;
                pacientestemp.Telefono = txt_telefono1.Text;
                pacientes.Add(pacientestemp);
                Guardarpacientes();
                txt_nitpaciente.Text = "";
                txt_nombre1.Text = "";
                txt_apellido1.Text  = "";
                txt_direccion1.Text = "";
                txt_telefono1.Text = "";
            }
            else
            {
                MessageBox.Show("El paciente ya existe en la base de datos, cambie el nit.");
            }
        }

        protected void Gridviewhistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = Gridviewhistorial.SelectedIndex;
            Gridviewsintomas.DataSource = historial[momentanea[0].Posihis].Cantidad[ind];
            Gridviewsintomas.DataBind();
        }

        protected void btn_agregarsintoma_Click(object sender, EventArgs e)
        {
            Sintomasagregados sintomtemp = new Sintomasagregados();
            sintomtemp.Codigosintoma = Convert.ToString(sintom.Count+1);
            sintomtemp.Sintoma = txt_ingresosintoma.Text;
            sintom.Add(sintomtemp);
            Guardarsintomasagregados();
        }

        protected void btn_agregarenfer_Click(object sender, EventArgs e)
        {
            Enfermedades enfermedadestemp = new Enfermedades();
            enfermedadestemp.Enfermedad = txt_enfermedades.Text;
            enfermedades.Add(enfermedadestemp);
            txt_enfermedades.Text = "";
        }

        protected void btn_guardarmed_Click(object sender, EventArgs e)
        {
            Medicamentos medicamentostemp = new Medicamentos();
            medicamentostemp.Codigo_medicamento = txt_codmedicamentos.Text;
            medicamentostemp.Ingrediente_generico = txt_ingredientegen.Text;
            medicamentostemp.Laboratorio = txt_laboratorio.Text;
            medicamentostemp.Enfermedades = enfermedades.ToList();
            medicamentos.Add(medicamentostemp);
            Guardarmedicamentos();
            txt_codmedicamentos.Text = "";
            txt_ingredientegen.Text = "";
            txt_laboratorio.Text = "";
            enfermedades.Clear();

        }

        protected void btn_eliminarsintoma_Click(object sender, EventArgs e)
        {
            sintom.RemoveAt(momentanea[0].Editsintomas);
            Guardarsintomasagregados();
            txt_buscarsintoma.Text = "";
            txt_editsintoma.Text = "";
            momentanea[0].Editsintomas = 0;
        }

        protected void btn_guardarcambiosintoma_Click(object sender, EventArgs e)
        {
            sintom[momentanea[0].Editsintomas].Codigosintoma = txt_buscarsintoma.Text;
            sintom[momentanea[0].Editsintomas].Sintoma = txt_editsintoma.Text;
            Guardarsintomasagregados();
            txt_buscarsintoma.Text = "";
            txt_editsintoma.Text = "";
            momentanea[0].Editsintomas = 0;
        }

        protected void btn_buscarsintoma_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < sintom.Count; x++)
            {
                if (txt_buscarsintoma.Text.CompareTo(sintom[x].Codigosintoma) == 0)
                {
                    momentanea[0].Editsintomas = x;
                    txt_editsintoma.Text = sintom[x].Sintoma;
                    break;
                }
            }
        }

        protected void btn_buscarcodigo_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < medicamentos.Count; x++)
            {
                if (txt_codigo.Text.CompareTo(medicamentos[x].Codigo_medicamento) == 0)
                {
                    momentanea[0].Editmedicamentos = x;
                    txt_editingrediente.Text = medicamentos[x].Ingrediente_generico;
                    txt_editlaboratorio.Text = medicamentos[x].Laboratorio;
                    grid_editmedicamentos.DataSource = medicamentos[x].Enfermedades;
                    grid_editmedicamentos.DataBind();
                    break;
                }
            }
        }

        protected void btn_editarenfermedad_Click(object sender, EventArgs e)
        {
            Enfermedades enfermedadestemp = new Enfermedades();
            enfermedadestemp.Enfermedad = txt_edienfermedades.Text;
            medicamentos[momentanea[0].Editmedicamentos].Enfermedades.Add(enfermedadestemp);
            txt_edienfermedades.Text = "";
            grid_editmedicamentos.DataSource = medicamentos[momentanea[0].Editmedicamentos].Enfermedades;
            grid_editmedicamentos.DataBind();
            Guardarmedicamentos();
        }

        protected void btn_eliminarenfermedad_Click(object sender, EventArgs e)
        {
            int indice = grid_editmedicamentos.SelectedIndex;
            medicamentos[momentanea[0].Editmedicamentos].Enfermedades.RemoveAt(indice);
            grid_editmedicamentos.DataSource = medicamentos[momentanea[0].Editmedicamentos].Enfermedades;
            grid_editmedicamentos.DataBind();
            Guardarmedicamentos();
        }

        protected void btn_guardareditarmedi_Click(object sender, EventArgs e)
        {
            Guardarmedicamentos();
            txt_codigo.Text = "";
            txt_edienfermedades.Text = "";
            medicamentos[momentanea[0].Editmedicamentos].Ingrediente_generico = txt_editingrediente.Text;
            medicamentos[momentanea[0].Editmedicamentos].Laboratorio = txt_editlaboratorio.Text;
            Guardarmedicamentos();
            txt_editingrediente.Text = "";
            txt_editlaboratorio.Text = "";
        }

        protected void btn_guardar_newusuario_Click(object sender, EventArgs e)
        {
            
        }
        protected void btn_guardarsintoma_Click(object sender, EventArgs e)
        {
            int indice = listadesintomas.SelectedIndex;
            Sintomas sintomastemp = new Sintomas();
            sintomastemp.Codigosintoma = sintom[indice].Codigosintoma;
            sintomastemp.Sintoma = sintom[indice].Sintoma;
            sintomas.Add(sintomastemp);
        }

        protected void btn_guardarconsulta_Click1(object sender, EventArgs e)
        {
            Histo histotemp = new Histo();
            Cantidad cantidadtemp = new Cantidad();
            histotemp.Diagnostico = txt_diagnostico.Text;
            histotemp.Proxima_visita = txt_proximavisita.Text;
            histotemp.Costo_consulta = txt_consulta.Text;
            histotemp.Sintomas = sintomas.ToList();
            histotemp.Tratamiento = tratamiento.ToList();
            histotemp.Presion = txt_presion.Text;
            histotemp.Temperatura = txt_temperatua.Text;
            histotemp.Fecha_consulta = momentanea[0].Fechaconsulta1;
            histotemp.Hora_consulta = momentanea[0].Horadeconsulta;
            histo.Add(histotemp);
            cantidadtemp.Histo = histo.ToList();
            cantidad.Add(cantidadtemp);

            if (momentanea[0].Existpaciente==0)
            {
                Pacientes pacientestemp = new Pacientes();
                pacientestemp.Nit_Paciente1 = txt_nitmed.Text;
                pacientestemp.Nombre = txt_nombre.Text;
                pacientestemp.Apellido = txt_apellido.Text;
                pacientestemp.Direccion = txt_apellido.Text;
                pacientestemp.Fecha_nacimiento1 = calfechanaci.SelectedDate;
                pacientestemp.Telefono = txt_telefono.Text;
                pacientes.Add(pacientestemp);
            }
            if (momentanea[0].Existhistorial==0)
            {
                Historial historialtemp = new Historial();
                historialtemp.Nit_paciente = txt_nitmed.Text;
                historialtemp.Cantidad = cantidad.ToList(); ;
                historial.Add(historialtemp);
            }
            else
            {
                historial[momentanea[0].Posihis].Cantidad.Add(cantidadtemp);
            }
            Guardarhistorial();
            txt_nitmed.Text = "";
            txt_nombre1.Text = "";
            txt_apellido1.Text = "";
            txt_direccion1.Text = "";
            txt_telefono1.Text = "";
            txt_temperatua.Text = "";
            txt_presion.Text = "";
            txt_diagnostico.Text = "";
            txt_receta.Text = "";
            txt_proximavisita.Text = "";
            txt_consulta.Text = "";
        }

        protected void btn_guardarreceta_Click1(object sender, EventArgs e)
        {
            int indice = gridtratamiento.SelectedIndex;
            Tratamiento tratamientotemp = new Tratamiento();
            tratamientotemp.Receta = medicamentos[indice].Ingrediente_generico;
            tratamientotemp.Instrucciones1 = txt_receta.Text;
            tratamiento.Add(tratamientotemp);
            txt_receta.Text = "";
        }

        protected void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Gridviewsintomas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_buscarhistorial_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < historial.Count; x++)
            {

            }
        }
    }
}