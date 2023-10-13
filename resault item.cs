using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace practice_3__amirmahdi_alipoor_
{
    public class resault_item
    {
        public string? key { get; set; }
        public string? name { get; set; }
        public string? name_en { get; set; }
        public int? rank { get; set; } 
        public double? dominance { get; set; } 
        public double? volume_24h { get; set; }
        public double? market_cap { get; set; }
        public double? ath { get; set; }
        public double? atl { get; set; }
        public double? ath_change_percentage { get; set; }
        public DateTime?  ath_date { get; set; }
        public double? price { get; set; }
        public double? daily_high_price { get; set; }
        public double? daily_low_price { get; set; }
        public double? weekly_high_price { get; set; }
        public double? monthly_high_price { get; set; }
        public double? yearly_high_price { get; set; }
        public double? weekly_low_price { get; set; }
        public double? monthly_low_price { get; set; }
        public double? yearly_low_price { get; set; }
        public double? percent_change_1h { get; set; }
        public double? percent_change_24h { get; set; }
        public double? percent_change_7d { get; set; }
        public double? percent_change_14d { get; set; }
        public double? percent_change_30d { get; set; }
        public double? percent_change_60d { get; set; }
        public double? percent_change_200d { get; set; }
        public double? percent_change_1y { get; set; }
        public double? price_change_24h { get; set; }
        public double? price_change_7d { get; set; }
        public double? price_change_14d { get; set; }
        public double? price_change_30d { get; set; }
        public double? price_change_60d { get; set; }
        public double? price_change_200d { get; set; }
        public double? price_change_1y { get; set; }
        public double? max_supply { get; set; }
        public double? total_supply { get; set; }
        public double? circulating_supply { get; set; }
        public string? type { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
