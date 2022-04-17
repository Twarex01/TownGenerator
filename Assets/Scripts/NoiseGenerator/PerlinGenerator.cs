using UnityEngine;

public class PerlinGenerator : INoiseGenerator
{
    PerlinGeneratorSettings generatorSettings;

    public PerlinGenerator(PerlinGeneratorSettings generatorSettings)
    {
        this.generatorSettings = generatorSettings;
    }

    public float Generate(int x, int y, float offsetX, float offsetY)
    {
        float xCoord = (x + offsetX) / generatorSettings.scale;
        float yCoord = (y + offsetY) / generatorSettings.scale;
        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
