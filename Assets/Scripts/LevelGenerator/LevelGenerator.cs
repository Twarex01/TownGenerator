using UnityEditor;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject tilePrefab;

    public int levelXSize;
    public int levelYSize;

    public void Start() 
    {
        GenerateMapFromTile();
    }


    public void ClearGeneratedTiles() 
    {
        while (transform.childCount != 0)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }

    public void GenerateMapFromTile()
    {
        while (transform.childCount != 0)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }

        var tileMeshGenerator = tilePrefab.GetComponent<TileMeshGenerator>();

        var xSize = tileMeshGenerator.tileXSize;
        var zSize = tileMeshGenerator.tileZSize;

        int i = 0;
        for (int xTileIndex = 0; xTileIndex < levelXSize; xTileIndex++)
        {
            for (int zTileIndex = 0; zTileIndex < levelYSize; zTileIndex++)
            {
                var tilePosition = new Vector3(
                    gameObject.transform.position.x + xTileIndex * xSize,
                    gameObject.transform.position.y,
                    gameObject.transform.position.z + zTileIndex * zSize);

                GameObject tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity);

                tile.GetComponent<TileMeshGenerator>().Init();

                tile.transform.SetParent(gameObject.transform);
                tile.transform.name = $"Tile {i}";

                i++;

                //TODO: TileData <- Biome, Zone
            }
        }
    }
}

[CustomEditor(typeof(LevelGenerator))]
class LevelGeneratorEditor : Editor
{
    LevelGenerator levelGenerator;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Generate"))
            levelGenerator.GenerateMapFromTile();

        if (GUILayout.Button("Clear"))
            levelGenerator.ClearGeneratedTiles();
    }

    private void OnEnable()
    {
        levelGenerator = (LevelGenerator)target;
    }
}

