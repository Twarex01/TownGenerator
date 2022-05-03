using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BiomePicker : MonoBehaviour
{
    //Dictionary workaround
    public List<BiomeDataSettings> biomeDataSettings;

    public void TestData() 
    {
        //TODO: Temp until automatic check, if possible

        if (biomeDataSettings.Select(x => x.name).Distinct().Count() != biomeDataSettings.Count)
            throw new System.Exception("Incorrect BiomeData settings!");
    }

    public BiomeDataSettings PickBiome(float height) 
    {
        return biomeDataSettings.OrderByDescending(x => x.minHeight).First(x => x.minHeight <= height);
    }
}
