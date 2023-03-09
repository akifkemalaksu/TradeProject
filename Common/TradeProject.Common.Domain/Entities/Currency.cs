using TradeProject.Shared.Entities;

namespace TradeProject.Common.Domain.Entities
{
    public class Currency : BaseEntity<Byte>
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Symbol { get; set; }
    }
}
