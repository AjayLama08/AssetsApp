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

var newAsset = new Asset(0, "Tesla Car", Location.KATHMANDU, DateTime.Now, true, 50000);

db.Assets.Add(newAsset);
db.SaveChanges();
