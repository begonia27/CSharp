namespace FarmSim;

public class Tile
{
    public delegate void TileGrowingHandler();

    public event TileGrowingHandler TileGrowing;
    public TileType Type;
    public TileStatus Status;

    public Tile(TileType type)
    {
        Type = type;
        Status = TileStatus.None;

        TileGrowing += OnTileGrowing;
    }

    public void OnTileGrowing()
    {
        Growing();
    }

    public void Growing()
    {
        if (Status == TileStatus.None)
        {
            Status = TileStatus.Growing;
        }
        else if (Status == TileStatus.Growing)
        {
            Status = TileStatus.Finish;

            // int x = d;
        }
    }

    public void Show()
    {
        Console.WriteLine($"{Type}, {Status}");
    }
}

public enum TileType
{
    Fruit,
    Vegetable
}

public enum TileStatus
{
    None,
    Growing,
    Finish
}
