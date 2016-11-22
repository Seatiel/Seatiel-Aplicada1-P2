using Entidades;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seatiel_Aplicada1_P2.UI.Registros
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var Cliente = new Clientes();
            if (!Validar())
            {
                MessageBox.Show("Complete los Campos");
                return;
            }
            Cliente.ClienteId = Convert.ToInt32(ClienteIdtextBox.Text);
            Cliente.Nombre = NombretextBox.Text;
            Cliente.Telefono = Convert.ToInt32(TelefonotextBox.Text);
            Cliente.LimiteCredito = Convert.ToInt32(LimiteCreditotextBox.Text);

            if (ClientesBLL.Insertar(Cliente))
            {
                MessageBox.Show("Guardado");
            }
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(ClienteIdtextBox.Text))
            {
                ClienteIderrorProvider.SetError(ClienteIdtextBox, "Debe introducir el ID del Cliente");
                NombreerrorProvider.SetError(NombretextBox, "Debe introducir el Nombre del Cliente");
                TelefonoerrorProvider.SetError(TelefonotextBox, "Debe introducir el Telefono del Cliente");
                LimiteCreditoerrorProvider.SetError(NombretextBox, "Debe introducir el Limite de credito del Cliente");
                retorno = false;
            }
            return retorno;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            /*ClientedataGridView.DataSource = null;
            int Id;
            int.TryParse(ClienteIdtextBox.Text, out Id);
            var Cliente = ClientesBLL.Buscar(Id);

            if (Cliente != null)
            {
                var ClienteTelefono = ClientesTelefonosBLL.GetList(Cliente.ClienteId);
                var TipoTelefono = TiposTelefonosBLL.GetList(ClientesTelefonos);
                NombretextBox.Text = Cliente.Nombre;
                ClientedataGridView.Visible = true;
                ClientedataGridView.DataSource = Cliente;
            }
            else
            {
                MessageBox.Show("No encontrado");
            }*/
        }
    }
}
