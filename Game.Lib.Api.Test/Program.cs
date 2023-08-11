using SteamStoreQuery;
using EpicGamesStoreNET;
using System.Globalization;
using System.Net;


static List<Listing> GetListings(string game, string cultureShortName, string cultureName)
{
    List<Listing> results = new List<Listing>();
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
    string response = new WebClient().DownloadString($"https://store.steampowered.com/search/suggest?term={game}&f=games&cc={cultureShortName}&lang={cultureName}&v=2286217");

    if (!response.Contains("match ds_collapse_flag "))
        return results;

    foreach (string s in response.Split(new string[] { "match ds_collapse_flag " }, StringSplitOptions.None))
        if (s.Contains("match_name") && s.Contains("match_price"))
            results.Add(new Listing(s));

    return results;
}



var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

CultureInfo trCulture = CultureInfo.GetCultureInfo("tr-TR");

var list = SteamStoreQuery.Query.Search("Baldurs Gate 3","ca");
foreach (var item in list)
{
    var price = item.Price.Value.ToString("C1", trCulture);
    Console.WriteLine($"Steam \n Oyun ismi: {item.Name} \n Oyunun Fiyatı: {price}  ");
}
    


var _ = EpicGamesStoreNET.Query.Search("Baldurs Gate 3");
foreach (var item in list)
    Console.WriteLine($"EpicGames \n Oyun ismi: {item.Name} \n Oyunun Fiyatı: {item.Price.Value.ToString("c1",trCulture)} ");