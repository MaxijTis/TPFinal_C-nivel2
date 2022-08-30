using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using Dominio;
namespace Acciones
{
    public void agregar(Articulo nuevo)
    {
        AccederDatos datos = new AccederDatos();

        try
        {
            datos.setConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, imagenUrl = @img, Marca = @marca, Categoria = @categoria, Precio = @precio Where Id = @id");
            datos.setParametro("@codigo", nuevo.CodArticulo);
            datos.setParametro("@nombre", nuevo.Nombre);
            datos.setParametro("@desc", nuevo.Descripcion);
            datos.setParametro("@img", nuevo.ImagenUrl);
            datos.setParametro("@marca", nuevo.Empresa);
            datos.setParametro("@categoria", nuevo.Tipo);
            datos.setParametro("@precio", nuevo.Precio);
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

    public void modificar(Articulo mod)
    {
        AccederDatos datos = new AccederDatos();
        try
        {
            datos.setConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, imagenUrl = @img, Marca = @marca, Categoria = @categoria, Precio = @precio Where Id = @id");
            datos.setParametro("@codigo", mod.CodArticulo);
            datos.setParametro("@nombre", mod.Nombre);
            datos.setParametro("@desc", mod.Descripcion);
            datos.setParametro("@img", mod.ImagenUrl);
            datos.setParametro("@marca", mod.Empresa);
            datos.setParametro("@categoria", mod.Tipo);
            datos.setParametro("@precio", mod.Precio);
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

    public List<Pokemon> filtrar(string campo, string criterio, string filtro)
    {
        List<Pokemon> lista = new List<Pokemon>();
        AccesoDatos datos = new AccesoDatos();
        try
        {
            string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 And ";
            if (campo == "Número")
            {
                switch (criterio)
                {
                    case "Mayor a":
                        consulta += "Numero > " + filtro;
                        break;
                    case "Menor a":
                        consulta += "Numero < " + filtro;
                        break;
                    default:
                        consulta += "Numero = " + filtro;
                        break;
                }
            }
            else if (campo == "Nombre")
            {
                switch (criterio)
                {
                    case "Comienza con":
                        consulta += "Nombre like '" + filtro + "%' ";
                        break;
                    case "Termina con":
                        consulta += "Nombre like '%" + filtro + "'";
                        break;
                    default:
                        consulta += "Nombre like '%" + filtro + "%'";
                        break;
                }
            }
            else
            {
                switch (criterio)
                {
                    case "Comienza con":
                        consulta += "P.Descripcion like '" + filtro + "%' ";
                        break;
                    case "Termina con":
                        consulta += "P.Descripcion like '%" + filtro + "'";
                        break;
                    default:
                        consulta += "P.Descripcion like '%" + filtro + "%'";
                        break;
                }
            }

            datos.setearConsulta(consulta);
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                Pokemon aux = new Pokemon();
                aux.Id = (int)datos.Lector["Id"];
                aux.Numero = datos.Lector.GetInt32(0);
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
                if (!(datos.Lector["UrlImagen"] is DBNull))
                    aux.UrlImagen = (string)datos.Lector["UrlImagen"];

                aux.Tipo = new Elemento();
                aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                aux.Debilidad = new Elemento();
                aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                lista.Add(aux);
            }

            return lista;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void eliminar(int id)
    {
        try
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("delete from pokemons where id = @id");
            datos.setearParametro("@id", id);
            datos.ejecutarAccion();

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void eliminarLogico(int id)
    {
        try
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("update POKEMONS set Activo = 0 Where id = @id");
            datos.setearParametro("@id", id);
            datos.ejecutarAccion();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
}
