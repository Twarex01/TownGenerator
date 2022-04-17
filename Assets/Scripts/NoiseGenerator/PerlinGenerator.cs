using UnityEngine;

public class PerlinGenerator : INoiseGenerator
{
    PerlinGeneratorSettings generatorSettings;

    public PerlinGenerator(PerlinGeneratorSettings generatorSettings)
    {
        this.generatorSettings = generatorSettings;
    }

    public float Generate(int x, int y)
    {
        float xCoord = x / generatorSettings.width * generatorSettings.scale;
        float yCoord = y / generatorSettings.height * generatorSettings.scale;
        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
