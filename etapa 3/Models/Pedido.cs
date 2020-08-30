using System.Collections.Generic;
using MySqlConnector;

namespace etapa_3.Models
{
    public  class Pedido
    {
        
     
        private static List<itemPedido> itempedido = new List<itemPedido>();

        public static void Incluir(itemPedido novoPedido)
        {
            itempedido.Add(novoPedido);
        }

        public static List<itemPedido> ListarPedido()
        {
            return itempedido;
        }

        public static double Total()
        {
            double subTotal = 0;
            double total = 0;
            for(int i = 0; i<itempedido.Count;i++)
            {
                subTotal += (itempedido[i].Quantidade * itempedido[i].Valor);
                total +=subTotal;
                subTotal=0;
            }
            return total;
        }

       

        
    }
}