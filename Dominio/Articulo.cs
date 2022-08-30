using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código de Articulo") ]
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Imagen del Articulo")]
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public Categoria Tipo { get; set; }    
        public Marcas Marca { get; set; }  
    }
}
