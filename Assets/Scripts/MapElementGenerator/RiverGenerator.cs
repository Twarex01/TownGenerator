using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverGenerator : IMapElementGenerator
{
    RiverGeneratorSettings generatorSettings;

    public RiverGenerator(RiverGeneratorSettings generatorSettings)
    {
        this.generatorSettings = generatorSettings;
    }

    public void Generate()
    {
        throw new System.NotImplementedException();
    }
}
