using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace T3H_Cap03_Desafio.Models
{
    public class Pedidos
    {
        [Display(Name = "Código do Pedido")]
        [Required]
        public int PedidoID { get; set; }
        [Required]
        [StringLength(40)]
        public string Produto { get; set; }
        [Required]
        public int Quantidade { get; set; } 
    }
}