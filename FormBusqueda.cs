using System;
using System.Drawing;
using System.Windows.Forms;

namespace Burbuja
{
    public partial class FormBusqueda : Form
    {
        public delegate void delegadoBusqueda(int dato);
        public event delegadoBusqueda enviarDato;
        public FormBusqueda()
        {
            InitializeComponent();
        }

        private void txtbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                enviarDato(int.Parse(txtbBuscar.Text));
                this.Close();
            }
        }
    }
}
