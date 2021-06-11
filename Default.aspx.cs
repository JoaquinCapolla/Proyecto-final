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
        int posi = 0;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Cargaragenda();
            Cargarcitas();
            Cargarhistorial();
            Cargarpacientes();
            Cargarmedicamentos();
            mostrarcitas();
            btn_asistencia.Visible = false;
            btn_cancelarcita.Visible = false;
        }
        
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_asistencia.Visible = true;
            btn_cancelarcita.Visible = true;
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
        void mostrarcitas()
        {
            Gridviewcitas.DataSource = agenda;
            Gridviewcitas.DataBind();
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
            string cons;
            Citas citastemp = new Citas();
            int indice = Gridviewcitas.SelectedIndex;
            citastemp.Nit_paciente = agenda[indice].Nit_paciente;
            citastemp.Fecha = agenda[indice].Fecha;
            citastemp.Hora_inicio = agenda[indice].Hora_inicio;
            citastemp.Hora_fin = agenda[indice].Hora_fin;
            cons = citastemp.Nit_paciente;
            citastemp.Asistencia = 1;
            citas.Add(citastemp);
            int va= 0;
            for (int x = 0; x < pacientes.Count; x++)
            {
                if (agenda[indice].Nit_paciente.CompareTo(pacientes[x].Nit_Paciente1) == 0)
                {
                    MessageBox.Show("El paciente ya estaba registrado no ingrese datos");
                    va = va+1;
                    posi = x;
                    txt_nitmed.Text= pacientes[posi].Nit_Paciente1;
                    txt_nombre.Text = pacientes[posi].Nombre;
                    txt_apellido.Text = pacientes[posi].Apellido;
                    txt_direccion.Text = pacientes[posi].Direccion;
                    txt_telefono.Text = pacientes[posi].Telefono;
                    txt_nitmed.Enabled = false;
                    txt_nombre.Enabled = false;
                    txt_apellido.Enabled = false;
                    txt_direccion.Enabled = false;
                    calfechanaci.Enabled = false;
                    txt_telefono.Enabled = false;
                    break;
                }
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
        }
        protected void btn_guardarsintoma_Click(object sender, EventArgs e)
        {

        }

        protected void btn_guardarconsulta_Click1(object sender, EventArgs e)
        {

        }

        protected void btn_guardarreceta_Click1(object sender, EventArgs e)
        {

        }

        protected void btn_administrativo_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            Panel2.Visible = false;
        }

        protected void btn_medico_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel4.Visible = false;
        }

        protected void btn_guardarpaciente_Click(object sender, EventArgs e)
        {
            pacientes
        }
    }
}