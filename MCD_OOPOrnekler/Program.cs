using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPOrnekler
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Classes.Product p1 = new Classes.Product()
                {
                    productName = "Ekmek",
                    productId = 1000,
                    productCategory = ProductCategories.Gıda
                };
                Classes.Product p2 = new Classes.Product()
                {
                    productName = "Şarj Aleti",
                    productId = 1001,
                    productCategory = ProductCategories.Elektronik
                };
                Classes.Product p3 = new Classes.Product()
                {
                    productName = "Süt",
                    productId = 1002,
                    productCategory = ProductCategories.Gıda
                };
                Classes.Product p4 = new Classes.Product()
                {
                    productName = "Şampuan",
                    productId = 1003,
                    productCategory = ProductCategories.Temizlik
                };

                Classes.Client c = new Classes.Client()
                {
                    clientId = 1,
                    gender = Genders.Erkek,
                    clientName = "Yakup",
                    clientSurname = "Kömük",
                    birthDate = new DateTime(1992, 07, 04),

                };

                Classes.ProductBasket cart = new Classes.ProductBasket()
                {
                    clientId = c.clientId,
                    basketId = 1
                };

                cart.productList.Add(p1);
                cart.productList.Add(p2);
                cart.productList.Add(p3);
                cart.productList.Add(p4);

                c.clientBasket = cart; //önce sepeti ve sepete eklenecek ürünleri yukarıda aldık daha sonra o sepeti müşteriye atadık.

                c.PrintClientInformations();
                c.PrintClientBasket();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}
