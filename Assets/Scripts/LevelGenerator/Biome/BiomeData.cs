using System;

[Serializable]
public class BiomeData
{
    public BiomeDataSettings biomeData;

    public float tileVertexPosX;

    public float tileVertexPosZ;

    public BiomeData(BiomeDataSettings biomeData, float tileVertexPosX, float tileVertexPosZ)
    {
        this.biomeData = biomeData;
        this.tileVertexPosX = tileVertexPosX;
        this.tileVertexPosZ = tileVertexPosZ;
    }
}
