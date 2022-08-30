using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Dominio;
using System.Configuration;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class frmControlArticulo : Form
    {

        private Articulo articulo = null;
        public frmControlArticulo()
        {
            InitializeComponent();
            TopMost = true;
        }

        public frmControlArticulo(Articulo articulo)
        {
            InitializeComponent();
            TopMost = true;
            this.articulo = articulo;
            Text = "Modificar Pokemon";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            conexionArticulo negocio = new conexionArticulo();
            if (String.IsNullOrEmpty(txbCodigo.Text))
            {
                lblVCodigo.Text = "* Campo Obligatorio";
                 txbCodigo.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(txbNombre.Text))
            {
                lblVNombre.Text = "* Campo Obligatorio";
                txbNombre.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(txbPrecio.Text))
            {
                lblVPrecio.Text = "* Campo Obligatorio";
                txbPrecio.BackColor = Color.Red;
                return;
            }

            if (txbCodigo.BackColor == Color.Red || txbNombre.BackColor == Color.Red || txbPrecio.BackColor == Color.Red) 
            {
                return;
            }
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodArticulo = (txbCodigo.Text);
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.ImagenUrl = txbImagenUrl.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.Tipo = (Categoria)cbxCategoria.SelectedItem;
                articulo.Marca = (Marcas)cbxMarca.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
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

        private void frmControlArticulo_Load(object sender, EventArgs e)
        {
            conexionCategorias Negocio = new conexionCategorias();
            conexionMarcas conexNegocio = new conexionMarcas();
            try
            {
                cbxCategoria.DataSource = Negocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = conexNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txbCodigo.Text = articulo.CodArticulo.ToString();
                    txbNombre.Text = articulo.Nombre;
                    txbDescripcion.Text = articulo.Descripcion;
                    txbImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txbPrecio.Text = articulo.Precio.ToString();
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Tipo.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txbImagenUrl_Leave_1(object sender, EventArgs e)
        {
            cargarImagen(txbImagenUrl.Text);
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbCodigo_Click(object sender, EventArgs e)
        {
            if (txbCodigo.BackColor == Color.Red)
            {
                lblVCodigo.Text = "";
                txbCodigo.BackColor = Color.White;
            }
            return;
            
        }

        private void txbNombre_Click(object sender, EventArgs e)
        {
            if (txbNombre.BackColor == Color.Red)
            {
                lblVNombre.Text = "";
                txbNombre.BackColor = Color.White;
            }

        }

        private void txbPrecio_Click(object sender, EventArgs e)
        {
            if (txbPrecio.BackColor == Color.Red)
            {
                lblVPrecio.Text = "";
                txbPrecio.BackColor = Color.White;
            }
        }
    }    
            
}

