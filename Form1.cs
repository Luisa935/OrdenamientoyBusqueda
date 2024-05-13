using Burbuja;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdenamientoYbusqueda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     
      private void ordenarToolStripMenuItem2_Click(object sender, EventArgs e)
       {
            Burbuja();
       }

        private void Burbuja()
        {
            object aux = null;
            for (int i = 0; i < lstDatos.Items.Count; i++)
            {
                for (int j = 0; j < lstDatos.Items.Count - 1; j++)
                {
                    if (Convert.ToInt32(lstDatos.Items[j]) >
                        Convert.ToInt32(lstDatos.Items[j + 1]))
                    {
                        aux = lstDatos.Items[j];
                        lstDatos.Items[j] = lstDatos.Items[j + 1];
                        lstDatos.Items[j + 1] = aux;
                    }
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
                FormBusqueda formBusca =new FormBusqueda();
                formBusca.enviarDato += Busca;
                formBusca.ShowDialog();
        }

        private void Busca(int dato)
        {
            bool encontrado = false;

            for (int i = 0; i < lstDatos.Items.Count; i++)
            {
                if (dato == Convert.ToInt32(lstDatos.Items[i]))
                {
                    lstDatos.SelectedIndex = i;
                    encontrado = true;
                    break;
                }
            }
                if (!encontrado)
                    MessageBox.Show("Dato no encontrado");
        }


            }

        }
    
