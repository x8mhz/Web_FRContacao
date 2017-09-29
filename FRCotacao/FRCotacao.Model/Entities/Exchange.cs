using System;

namespace FRCotacao.Model.Entities
{
    public class Exchange
    {
        public int ExchangeId { get; set; }
        public DateTime Hour { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
    }
}
