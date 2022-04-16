public class PerlinGenerator : INoiseGenerator
{
    PerlinGeneratorSettings generatorSettings;

    public PerlinGenerator(PerlinGeneratorSettings generatorSettings)
    {
        this.generatorSettings = generatorSettings;
    }

    public float Generate(int x, int y)
    {
        throw new System.NotImplementedException();
    }
}
