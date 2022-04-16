public static class NoiseGeneratorFactory
{
    public static INoiseGenerator CreateNoiseGenerator(NoiseGeneratorSettings settings)
    {
        switch (settings.generatorType)
        {
            case NoiseGeneratorType.Perlin:
                return new PerlinGenerator(settings.perlinGeneratorSettings);
        }
        return null;
    }
}