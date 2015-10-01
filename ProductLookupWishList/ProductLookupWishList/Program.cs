using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWishList
{

    class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class ProductCatalog
    {
        public List<Product> ProductList { get; set; }
        public Dictionary<string, Product> ProductDictionary { get; set; }

        public ProductCatalog()
        {
            ProductDictionary = new Dictionary<string, Product>();
            ProductList = new List<Product>();

            ProductList.Add(new Product { Id = "100", Name = "Nike", Price = 150 });
            ProductList.Add(new Product { Id = "101", Name = "Addidas", Price = 175 });
            ProductList.Add(new Product { Id = "102", Name = "Reebok", Price = 105 });

            foreach (var item in ProductList)
            {
                ProductDictionary.Add(item.Id, item);
            }
        }



        public Product Lookup(string id)


        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Id == id)
                {
                    return ProductList[i];
                }
            }
            return null;
        }

        public Product LookUpKey(string id)
        {
            if (ProductDictionary.ContainsKey(id))
            {
                return ProductDictionary[id];
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(new ProductCatalog().LookUpKey("100").Price == 150, "Not in inventory.");
        }
    }


}
    
