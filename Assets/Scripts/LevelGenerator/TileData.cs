using System;
using System.Collections.Generic;

[Serializable]
public class TileData
{
    public List<BiomeData> biomeDatas;

    public TileData(List<BiomeData> biomeDatas)
    {
        this.biomeDatas = biomeDatas;
    }
}
