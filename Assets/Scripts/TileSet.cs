using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum TileType {
    Rock,
    Soil,
    Growing,
    Harvestable
}

[CreateAssetMenu(fileName = "TileSet", menuName = "TileSet")]
public class TileSet : ScriptableObject
{
    public TileBase tileBase;
    public TileType type;
}