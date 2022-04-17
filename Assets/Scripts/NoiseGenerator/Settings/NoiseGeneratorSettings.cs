using System;

[Serializable]
public class NoiseGeneratorSettings
{
    public BaseGeneratorSettings baseGeneratorSettings;

    public NoiseGeneratorType generatorType;

    public PerlinGeneratorSettings perlinGeneratorSettings;
}
