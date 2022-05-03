using System;

[Serializable]
public class BiomeData
{
    public BiomeDataSettings biomeData;

    public float tilePosX;

    public float tilePosZ;

    public BiomeData(BiomeDataSettings biomeData, float tilePosX, float tilePosZ)
    {
        this.biomeData = biomeData;
        this.tilePosX = tilePosX;
        this.tilePosZ = tilePosZ;
    }
}
