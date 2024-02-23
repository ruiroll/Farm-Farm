using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileChange : MonoBehaviour
{
    public Tilemap tilemap;
    public TileSet rockTile;
    public TileSet soilTile;
    public TileSet growingTile;
    public TileSet harvestableTile;
    public bool changeTile = false;

    public void ChangeTileType(Vector3 posi)
    {
        Vector3Int pos = tilemap.WorldToCell(Vector3Int.RoundToInt(posi));
        TileBase tb = tilemap.GetTile(pos);

        if(tb == rockTile.tileBase)
        {
            tilemap.SetTile(pos, soilTile.tileBase);
        }
        else if(tb == soilTile.tileBase)
        {
            tilemap.SetTile(pos, growingTile.tileBase);
            StartCoroutine(Grow(pos));
        }
        else if(tb == harvestableTile.tileBase)
        {
            tilemap.SetTile(pos, soilTile.tileBase);
        }
    }

    IEnumerator Grow(Vector3Int pos)
    {
	    yield return new WaitForSeconds(5.0f);
    
        tilemap.SetTile(pos, harvestableTile.tileBase);
    }
}
