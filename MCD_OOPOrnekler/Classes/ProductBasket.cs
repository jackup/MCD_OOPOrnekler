using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPOrnekler.Classes
{
    class ProductBasket
    {
        public int basketId { get; set; }
        public int clientId { get; set; }
        public List<Product> productList { get; set; } = new List<Product>(); //new anahtarı olmadan da yapılabilir.
        public void AddBirthdayPresent()
        {
            Product gift = new Product()
            {
                productName = "Gofret",
                productId = 300,
                productCategory = ProductCategories.Gıda
            };
            productList.Add(gift);
        }
    }
}
