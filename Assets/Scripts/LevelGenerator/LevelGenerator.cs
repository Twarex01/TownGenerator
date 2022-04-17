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

    public void GenerateMapFromTile()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
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
                    this.gameObject.transform.position.x + xTileIndex * xSize,
                    this.gameObject.transform.position.y,
                    this.gameObject.transform.position.z + zTileIndex * zSize);

                GameObject tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity);

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
    }

    private void OnEnable()
    {
        levelGenerator = (LevelGenerator)target;
    }
}

