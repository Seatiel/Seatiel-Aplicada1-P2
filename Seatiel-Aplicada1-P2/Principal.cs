using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seatiel_Aplicada1_P2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seatiel_Aplicada1_P2.UI.Registros.RegistroClientes rc = new UI.Registros.RegistroClientes();
            rc.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seatiel_Aplicada1_P2.UI.Consultas.Consulta c = new UI.Consultas.Consulta();
            c.Show();
        }
    }
}
