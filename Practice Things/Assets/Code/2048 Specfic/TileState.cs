using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Here to hold info and be on the create menu for asset things. 
[CreateAssetMenu(menuName = "Tile State")]
public class TileState : ScriptableObject
{
    public Color backgroundColor;
    public Color textColor;
}
