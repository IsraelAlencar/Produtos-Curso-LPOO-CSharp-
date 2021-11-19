using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos.Entities {
    class UsedProduct : Product{
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (Used) $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append($"Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")}");
            
            return sb.ToString();
        }
    }
}
