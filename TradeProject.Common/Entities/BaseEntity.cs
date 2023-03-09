using System;
using System.Collections.Generic;
using System.Text;

namespace TradeProject.Common.Entities
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public bool Deleted { get; set; }
    }
}
