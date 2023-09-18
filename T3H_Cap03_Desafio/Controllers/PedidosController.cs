using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T3H_Cap03_Desafio.Models;
using System.IO;

namespace T3H_Cap03_Desafio.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]  // default não precisa colocar
        public ActionResult IncluirPedidoTipado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirPedidoTipado(Pedidos pedido)
        {
            // neste momento a aplicaçãoestá recebendo
            if (!ModelState.IsValid) return View();
            string arquivo = $"C:\\pedido{pedido.PedidoID}.txt";
            //StreamWriter sw = new StreamWriter("C:\\Pedido.txt");
            StreamWriter sw = new StreamWriter(arquivo);
            string pedidoRealizado = $"Pedido: {pedido.PedidoID} Produto: {pedido.Produto} Quantidade: {pedido.Quantidade} ";
            try
            {
                sw.WriteLine(pedidoRealizado);
                sw.Close();
                return View("PedidoGravado");
            }
            catch (Exception)
            {

                throw;
            }          
        }
   

        [HttpGet]
        public ActionResult ListarPedidoTipado()
        {
            string arquivo = $"C:\\pedido{1}.txt";
            try
            {
                StreamReader sr = new StreamReader(arquivo);
                string retorno = sr.ReadToEnd();
                sr.Close();
                ViewBag.Message = retorno;
                return View("MostraPedido");
            }
            catch (Exception)
            {

                throw;
            }
        
         
           
        }

    }
}