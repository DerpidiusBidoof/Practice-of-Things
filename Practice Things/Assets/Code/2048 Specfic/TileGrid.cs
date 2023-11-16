using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public TileRow[] rows { get; private set; }
    public TileCell[] cells { get; private set; }

    public int size => cells.Length;
    public int height => rows.Length;
    public int width => size / height;

    public void Awake()
    {
        rows = GetComponentsInChildren<TileRow>();
        cells = GetComponentsInChildren<TileCell>();
    }

    public void Start()
    {
        for (int y  = 0; y < rows.Length; y++)
        {
            for( int x = 0; x < rows[y].cells.Length; x++)
            {
                rows[y].cells[x].cellCoordinates = new Vector2Int(x, y);
            }
        }
    }

    public TileCell GetRandomEmptyCell()
    {
        int index = Random.Range(0, cells.Length);
        int startingIndex = index;

        while (cells[index].isCellFull)
        {
            index++;

            if(index >= cells.Length)
            {
                index = 0;
            }

            if (index == startingIndex)
            {
                return null; 
            }
        }

        return cells[index];
    }
}
