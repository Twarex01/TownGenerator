using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData
{
    public int PosX { get; set; }

    public int PosZ { get; set; }

    public int[,] HeightMap { get; set; }

    public Zone[,] Zones { get; set; }
}
