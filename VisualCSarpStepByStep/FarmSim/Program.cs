namespace FarmSim;

class Program
{

    static void Main(string[] args)
    {
        Farm abasdfasd = new Farm(new List<TileType>() {TileType.Fruit, TileType.Vegetable});
        
        abasdfasd.Show();
        
        abasdfasd.AddTile(TileType.Vegetable);
        
        abasdfasd.AddTile(new Tile(TileType.Fruit));
        
        abasdfasd.Show();
    }
}
