public static class MapElementGeneratorFactory
{
    public static IMapElementGenerator CreateMapElementGenerator(MapElementGeneratorSettings settings)
    {
        switch (settings.generatorType)
        {
            case MapElementGeneratorType.Forrest:
                return new ForrestGenerator(settings.forrestGeneratorSettings);
            case MapElementGeneratorType.River:
                return new RiverGenerator(settings.riverGeneratorSettings);
            case MapElementGeneratorType.Building:
                return new BuildingGenerator(settings.buildingGeneratorSettings);
            case MapElementGeneratorType.Town:
                return new TownGenerator(settings.townGeneratorSettings);
        }
        return null;
    }
}