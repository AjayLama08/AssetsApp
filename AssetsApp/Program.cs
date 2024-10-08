using AssetsApp.Data;

static void displayAssets(List<Asset> assets)
{
    foreach (var asset in assets)
    {
        Console.WriteLine(asset);
    }
}

using var db = new AssetsDbContext();

var assets = db.Assets.ToList();    

displayAssets(assets);
