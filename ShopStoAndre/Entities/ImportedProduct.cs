using System;
using System.Collections.Generic;
using System.Text;

namespace ShopStoAndre.Entities
{
    class ImportedProduct : Product
    {
        public double CostomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double costomsFee): base(name,price)
        {
            CostomsFee = costomsFee;
        }
        public override string PriceTag()
        {
            Price += CostomsFee;
            return base.PriceTag() + ("Costoms fee: $"+CostomsFee);
        }
    }
}
