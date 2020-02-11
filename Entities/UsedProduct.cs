using System;
using System.Globalization;

namespace Aula132Produto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        public override string PriceTag()
        {
            int pos = base.PriceTag().IndexOf("$");
            string s1 = base.PriceTag().Substring(0, pos - 1) + " (used) " + base.PriceTag().Substring(pos);
            return  s1 + "(Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + ")";
        }
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
        : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
    }
}
