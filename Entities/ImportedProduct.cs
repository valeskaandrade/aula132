
using System.Globalization;

namespace Aula132Produto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public override string PriceTag()
        {
            int pos = base.PriceTag().IndexOf("$");
            string s1 = base.PriceTag().Substring(0, pos + 2) +  TotalPrice().ToString("F2", CultureInfo.InvariantCulture);

            return s1 + "(Customs fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) 
        : base (name, price)
        {
            CustomsFee = customsFee;
        }
    }
}
