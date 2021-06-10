using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_final
{
    public partial class _Default : Page
    {
        static List<Agenda> agenda = new List<Agenda>();
        protected void Page_Load(object sender, EventArgs e)
        {

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

        }
    }
}