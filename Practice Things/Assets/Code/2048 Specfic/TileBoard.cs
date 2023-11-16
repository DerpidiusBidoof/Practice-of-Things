using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBoard : MonoBehaviour
{
    public Tile tilePrefab;
    public TileState[] tileStates;

    private TileGrid grid;
    private List<Tile> tiles;

    public int startTileNumber;

    private void Awake()
    {
        grid = GetComponentInChildren<TileGrid>();
        tiles = new List<Tile>(16);
    }


    // Start is called before the first frame update
    void Start()
    {
        CreateTile(); 
        CreateTile(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateTile()
    {
        Tile tile = Instantiate(tilePrefab, grid.transform);

        tile.SetState(tileStates[0], startTileNumber);
        tile.SpawnTile(grid.GetRandomEmptyCell());

        tiles.Add(tile);
    }
}
