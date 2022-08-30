using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Conexion
{
    public class conexionArticulo
    {
        public List<Articulo> listaArticulo;
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccederDatos datos = new AccederDatos();
            try
            {
                datos.setConsulta("select  A.Id, Codigo, Nombre, A.Descripcion, M.Id, C.Id,IdMarca, IdCategoria, M.Descripcion Marca, C.Descripcion Tipo, ImagenUrl, Precio from Articulos A, Marcas M, Categorias C where IdMarca = M.Id and IdCategoria = C.Id and IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Tipo = new Categoria();
                    aux.Tipo.Id = (int)datos.Lector["IdCategoria"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];

                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccederDatos datos = new AccederDatos();

            try
            {
                datos.setConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values('" + nuevo.CodArticulo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @IdMarca, @idCategoria, @ImagenUrl, @Precio)");
                datos.setParametro("@IdMarca", nuevo.Marca.Id);
                datos.setParametro("@IdCategoria", nuevo.Tipo.Id);
                datos.setParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.setParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo Art)
        {
            AccederDatos datos = new AccederDatos();
            try
            {
                datos.setConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, ImagenUrl = @img, IdMarca = @idmarca, Precio = @precio, Idcategoria = @idCategoria Where Id = @id");
                datos.setParametro("@codigo", Art.CodArticulo);
                datos.setParametro("@nombre", Art.Nombre);
                datos.setParametro("@desc", Art.Descripcion);
                datos.setParametro("@img", Art.ImagenUrl);
                datos.setParametro("@idmarca", Art.Marca.Id);
                datos.setParametro("@idCategoria", Art.Tipo.Id);
                datos.setParametro("@precio", Art.Precio);
                datos.setParametro("@id", Art.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccederDatos datos = new AccederDatos();
                datos.setConsulta("delete from ARTICULOS where id = @id");
                datos.setParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Articulo> filtrar(string marca, string categoria,string filtro, string criterio) 
        {
            List<Articulo> lista = new List<Articulo>();
            AccederDatos datos = new AccederDatos();
            try
            {
                string consulta = "select  A.Id, Codigo, Nombre, A.Descripcion, M.Id, C.Id,IdMarca, IdCategoria, M.Descripcion Marca, C.Descripcion Tipo, ImagenUrl, Precio from Articulos A, Marcas M, Categorias C where IdMarca = M.Id and IdCategoria = C.Id and    ";
                
                if (marca != "-Elije una Opción-")
                {
                    if (!(categoria.Equals(null)))
                    {
                        if (criterio == "Nombre")
                        {
                            consulta += "Nombre like '%" + filtro + "%'" + "and M.Descripcion like '" + marca + "'" + "and C.Descripcion like '%" + categoria + "%'";
                        }
                        else
                        {
                            consulta += "A.Descripcion like '%" + filtro + "%'" + "and M.Descripcion like '" + marca + "'" + "and C.Descripcion like '%" + categoria + "%'";
                        }
                    }
                }
                    datos.setConsulta(consulta);
                    datos.ejecutarLectura();
                    while (datos.Lector.Read())
                    {
                        Articulo aux = new Articulo();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.CodArticulo = (string)datos.Lector["Codigo"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        if (!(datos.Lector["ImagenUrl"] is DBNull))
                            aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                        aux.Precio = (decimal)datos.Lector["Precio"];

                        aux.Marca = new Marcas();
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                        aux.Tipo = new Categoria();
                        aux.Tipo.Id = (int)datos.Lector["IdCategoria"];
                        aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];

                        lista.Add(aux);
                    }   
            return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
