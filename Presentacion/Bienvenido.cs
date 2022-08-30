using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmBienvenido : Form
    {
        public frmBienvenido()
        {
            InitializeComponent();
        }

        private void abrirVentana() 
        {
            frmCentral Principal = new frmCentral();
            Principal.ShowDialog();         
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirVentana();
        }

        private void tsAcerca_Click(object sender, EventArgs e)
        {         
            MessageBox.Show("Proyecto como desafio final de MAXIPROGRAMA, C# .Net Nivel 2. Alumno Maximiliano Jesús Tis");
        }

        private void tsStock_Click(object sender, EventArgs e)
        {
            abrirVentana();
        }

        private void tsCerrar_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void controlDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentana();
        }

        private void lblhGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Quiere ver el codigo de esta app?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/MaxijTis/TPFinal_C-nivel2.git");
            }

        }
    }
}
