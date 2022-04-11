using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownGenerator : IMapElementGenerator
{
    TownGeneratorSettings generatorSettings;

    public TownGenerator(TownGeneratorSettings generatorSettings)
    {
        this.generatorSettings = generatorSettings;
    }

    public void Generate()
    {
        throw new System.NotImplementedException();
    }
}
