
using Newtonsoft.Json;
using practice_3__amirmahdi_alipoor_;
using System.Text.Json.Serialization;



await RunInBackground(TimeSpan.FromSeconds(5), () => InitAsync());

async Task RunInBackground(TimeSpan timeSpan, Action action)
{
var periodicTimer = new PeriodicTimer(timeSpan);
while (await periodicTimer.WaitForNextTickAsync())
{
action();
}
}



async Task InitAsync()
{
    HttpClient httpClient = new HttpClient();
    string stringApi = "https://api.wallex.ir/v1/currencies/stats";

    HttpResponseMessage response = await httpClient.GetAsync(stringApi);
    if (response.IsSuccessStatusCode)
    {
        string apiresponse = await response.Content.ReadAsStringAsync();


        Apirespons? apidata = JsonConvert.DeserializeObject<Apirespons>(apiresponse);

        List<resault_item> Result_Items = apidata.result;

        foreach (var item in Result_Items)
        {
            Console.WriteLine($"key:{item.key}");
            //Console.WriteLine($"name:{item.name}");
            Console.WriteLine($"name_en:{item.name_en}");
            Console.WriteLine($"rank:{item.rank}");
            //Console.WriteLine($"dominance:{item.dominance}");
            //Console.WriteLine($"volume_24h:{item.volume_24h}");
            //Console.WriteLine($"market_cap:{item.market_cap}");
            //Console.WriteLine($"ath:{item.ath}");
            //Console.WriteLine($"atl:{item.atl}");
            //Console.WriteLine($"ath_change_percentage:{item.ath_change_percentage}");
            //Console.WriteLine($"ath_date:{item.ath_date}");
            Console.WriteLine($"price:{item.price}");
            //Console.WriteLine($"daily_high_price:{item.daily_high_price}");
            //Console.WriteLine($"daily_low_price:{item.daily_low_price}");
            //Console.WriteLine($"weekly_high_price:{item.weekly_high_price}");
            //Console.WriteLine($"monthly_high_price:{item.monthly_high_price}");
            //Console.WriteLine($"yearly_high_price:{item.yearly_high_price}");
            //Console.WriteLine($"weekly_low_price:{item.weekly_low_price}");
            //Console.WriteLine($"monthly_low_price:{item.monthly_low_price}");
            //Console.WriteLine($"yearly_low_price:{item.yearly_low_price}");
            //Console.WriteLine($"percent_change_1h:{item.percent_change_1h}");
            //Console.WriteLine($"percent_change_24h:{item.percent_change_24h}");
            //Console.WriteLine($"percent_change_7d:{item.percent_change_7d}");
            //Console.WriteLine($"percent_change_14d:{item.percent_change_14d}");
            //Console.WriteLine($"percent_change_30d:{item.percent_change_30d}");
            //Console.WriteLine($"percent_change_60d:{item.percent_change_60d}");
            //Console.WriteLine($"percent_change_200d:{item.percent_change_200d}");
            //Console.WriteLine($"percent_change_1y:{item.percent_change_1y}");
            //Console.WriteLine($"price_change_24h:{item.price_change_24h}");
            //Console.WriteLine($"price_change_7d:{item.price_change_7d}");
            //Console.WriteLine($"price_change_14d:{item.price_change_14d}");
            //Console.WriteLine($"price_change_30d:{item.price_change_30d}");
            //Console.WriteLine($"price_change_60d:{item.price_change_60d}");
            //Console.WriteLine($"price_change_200d:{item.price_change_200d}");
            //Console.WriteLine($"price_change_1y:{item.price_change_1y}");
            //Console.WriteLine($"max_supply:{item.max_supply}");
            //Console.WriteLine($"total_supply:{item.total_supply}");
            //Console.WriteLine($"circulating_supply:{item.circulating_supply}");
            Console.WriteLine($"type:{item.type}");
            Console.WriteLine($"created_at:{item.created_at}");
            Console.WriteLine($"updated_at:{item.updated_at}");
            

            //price average in a last year : 25.44
            double? predict = item.price + 25.44;
            Console.WriteLine("price prediction :"+predict);
            Console.WriteLine("\n");
            Console.WriteLine("please insert ENTER to swith the coin :)");
            Console.ReadKey();
        }
    


    }
   
}