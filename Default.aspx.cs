using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_final
{
    public partial class _Default : Page
    {
        static List<Agenda> agenda = new List<Agenda>();
        static List<Citas> citas = new List<Citas>();
        static List<Sintomas> sintomas = new List<Sintomas>();
        static List<Histo> histo= new List<Histo>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            Citas citastemp = new Citas();
            int indice = Gridviewcitas.SelectedIndex;
            citastemp.Nit_paciente = agenda[indice].Nit_paciente;
            citastemp.Fecha = agenda[indice].Fecha;
            citastemp.Hora_inicio = agenda[indice].Hora_inicio;
            citastemp.Hora_fin = agenda[indice].Hora_fin;
            citastemp.Asistencia = 1;
            citas.Add(citastemp);
            agenda.RemoveAt(indice);
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
            Sintoma sintomatemp = new Sintoma();
            sintomatemp.Codigo_sintoma =
        }

        protected void btn_guardarreceta_Click(object sender, EventArgs e)
        {

        }

        protected void btn_guardarconsulta_Click(object sender, EventArgs e)
        {

        }
    }
}