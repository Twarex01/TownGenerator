﻿using UnityEngine;

public class PerlinGenerator : INoiseGenerator
{
    PerlinGeneratorSettings generatorSettings;

    public PerlinGenerator(PerlinGeneratorSettings generatorSettings)
    {
        this.generatorSettings = generatorSettings;
    }

    public float Generate(int x, int y, float offsetX, float offsetY)
    {
        float xCoord = (x + offsetX) / generatorSettings.width * generatorSettings.scale;
        float yCoord = (y + offsetY) / generatorSettings.height * generatorSettings.scale;
        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
