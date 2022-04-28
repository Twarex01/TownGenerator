using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData
{
    private List<TileData> tileDatas = new List<TileData>();

    public IReadOnlyList<TileData> TileDatas => tileDatas;

    public void AddTileData(TileData tileData) 
    {
        tileDatas.Add(tileData);
    }
}
