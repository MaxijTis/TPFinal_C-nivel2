using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Conexion;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class frmCentral : Form
    {

        private List<Articulo> listaArticulos;

        public frmCentral()
        {
            InitializeComponent();
        }
        private void frmCentral_Load(object sender, EventArgs e)
        {
            cargar();
            cargaCombos(); 
        }

        public void cargar()
        {
            conexionArticulo conectar = new conexionArticulo();
            try
            {
                listaArticulos = conectar.listar();
                dgvStock.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void ocultarColumnas()
        {
            dgvStock.Columns["ImagenUrl"].Visible = false;
            dgvStock.Columns["Id"].Visible = false;
        }

        private void cargaCombos() 
        {
            cbxMarcas.Items.Insert(0, "-Elije una Opción-");
            cbxMarcas.SelectedIndex = 0;
            cbxMarcas.Items.Add("Samsung");
            cbxMarcas.Items.Add("Apple");
            cbxMarcas.Items.Add("Sony");
            cbxMarcas.Items.Add("Motorola");
            cbxMarcas.Items.Add("Huawei");
        }

        private bool validarFiltro()
        {
            if (cbxMarcas.SelectedIndex > 0 && cbxCategorias.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una Categoria para filtrar.");
                return true;      
            }
            if (cbxCategorias.SelectedIndex >= 0 && cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un criterio...");
                return true;
            }
            return false;
        }

        private bool validarBotones() 
        {
            if (dgvStock.RowCount == 0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                return true;
            }
            else 
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                return true;
            }         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmControlArticulo ventana = new frmControlArticulo();
            ventana.ShowDialog();
            cargar();
            validarBotones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //foreach (var item in Application.OpenForms)
            //{
            //    if (item.GetType() == typeof(frmControlArticulo))
            //    {
            //        MessageBox.Show("Usted ya abrio esta ventana");
            //        return;
            //    }
            //}
            Articulo seleccionado;
            seleccionado = (Articulo)dgvStock.CurrentRow.DataBoundItem;

            frmControlArticulo modificar = new frmControlArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
            if (validarBotones()) 
            {
                return;
            }   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionArticulo articuloNegocio = new conexionArticulo();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvStock.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminar(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexionArticulo lista = new conexionArticulo();
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;
            
            if (cbxMarcas.SelectedIndex == 0)
            {
                if (filtro.Length >= 3)
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CodArticulo.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = listaArticulos;
                }
                dgvStock.DataSource = null;
                dgvStock.DataSource = listaFiltrada;
                ocultarColumnas();
                validarBotones();
            }
            else
            {
                try
                {
                    if (validarFiltro())
                        return;
                       
                    string marca = cbxMarcas.SelectedItem.ToString();
                    string categoria = cbxCategorias.SelectedItem.ToString();
                    string criterio = cbxCriterio.SelectedItem.ToString();
                    dgvStock.DataSource = lista.filtrar(marca, categoria, filtro, criterio);
                    ocultarColumnas();
                    validarBotones();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvStock.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cbxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbxMarcas.SelectedIndex > 0)
            {
                cbxCategorias.Items.Clear();
                cbxCriterio.Items.Clear();

                cbxCategorias.Items.Add("Celulares");
                cbxCategorias.Items.Add("Televisores");
                cbxCategorias.Items.Add("Media");
                cbxCategorias.Items.Add("Audio");
            }
            else
            {
                cbxCategorias.Items.Clear();
                cbxCriterio.Items.Clear();
            }
        }

        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxCategorias.SelectedIndex >= 0)
            {
                cbxCriterio.Items.Clear();  
                cbxCriterio.Items.Add("Nombre");
                cbxCriterio.Items.Add("Descripción");
            }
            else 
            {
                cbxCriterio.Items.Clear();
            }

        }
    }

}
