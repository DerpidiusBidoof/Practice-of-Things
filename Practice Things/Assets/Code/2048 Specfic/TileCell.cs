using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCell : MonoBehaviour
{
    public Vector2Int cellCoordinates { get; set; }

    public Tile tile { get; set; }

    public bool isCellEmpty => tile == null; //Cell is empty if tile return null
    public bool isCellFull => tile != null; // Cell is full if tile returns a value
}
