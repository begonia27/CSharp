namespace FarmSim;

public class Farm
{
    public List<Tile> Tiles = new List<Tile>();

    public Farm(List<TileType> types)
    {
        foreach (TileType type in types)
        {
            Tiles.Add(new Tile(type));
        }
    }

    public void Show()
    {
        foreach (Tile tile in Tiles)
        {
            tile.Show();
        }
        
        Console.WriteLine();
    }

    public void AddTile(TileType type)
    {
        Tiles.Add(new Tile(type));
    }

    public void AddTile(Tile tile)
    {
        Tiles.Add(tile);
    }
}
