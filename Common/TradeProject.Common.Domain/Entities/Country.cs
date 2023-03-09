using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeProject.Shared.Entities;

namespace TradeProject.Common.Domain.Entities
{
    public class Country : BaseEntity<Int16>
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public decimal VatRate { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
