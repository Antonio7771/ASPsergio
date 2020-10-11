using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using antonioasp.Models;

namespace antonioasp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //datos producto
            producto _producto = new producto();
            _producto.ID = 12;
            _producto.nombre = "coca cola";
            _producto.presio = 14;
            _producto.Cantidad = 2;

            //datos provedor 
            provedores _provedor = new provedores();
            _provedor.ID_provedor = 23;
            _provedor.Nombre = "coca cola empresa sv de cv";
            _provedor.Producto = "refrescos coca cola";

            //datos Registro
            Registro _registro = new Registro();
            _registro.Nombre = "juan peres";
            _registro.Edad = "1986/02/10";
            _registro.FechaRegistro = DateTime.Now;


            Dictionary<string, string> datos = new Dictionary<string, string>();
            //datos de producto en diccionario
            datos.Add("ID_producto",Convert.ToString (_producto.ID));
            datos.Add("nombre_producto",_producto.nombre);
            datos.Add("presio_producto",Convert.ToString (_producto.presio));
            datos.Add("cantidad_producto",Convert.ToString(_producto.Cantidad));
            //datos de provedor en diccionario
            datos.Add("ID_provedor",Convert.ToString (_provedor.ID_provedor));
            datos.Add("nombre_provedor",_provedor.Nombre);
            datos.Add("producto_provedor",_provedor.Producto);

            //datos de registro a diccionario
            datos.Add("nombre_registro",_registro.Nombre);
            datos.Add("edad_registro",_registro.Edad);
            datos.Add("fecha_registro",Convert.ToString (_registro.FechaRegistro));

            return View(datos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
