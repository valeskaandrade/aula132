
using System.Globalization;

namespace Aula132Produto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual string PriceTag() 
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
        public Product() 
        { 
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
