using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGenerator : IMapElementGenerator
{
    BuildingGeneratorSettings generatorSettings;

    public BuildingGenerator(BuildingGeneratorSettings generatorSettings)
    {
        this.generatorSettings = generatorSettings;
    }

    public void Generate()
    {
        throw new System.NotImplementedException();
    }
}
