using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductoEjmplo.Models.ProductoViewModels
{
[Table("producto")]

    public class Producto
{
    public int ID { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int Cantidad { get; set; }
}
}
