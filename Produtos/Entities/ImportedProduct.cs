using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos.Entities {
    class ImportedProduct : Product {
        public double CustomsFee { get; set; }

        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price + CustomsFee;
        }

        public override string PriceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append($"(Customs fee: $ {CustomsFee})");

            return sb.ToString();
        }
    }
}
