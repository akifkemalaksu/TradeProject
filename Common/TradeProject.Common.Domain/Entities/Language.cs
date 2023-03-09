using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeProject.Shared.Entities;

namespace TradeProject.Common.Domain.Entities
{
    public class Language : BaseEntity<Byte>
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Culture { get; set; }
    }
}
