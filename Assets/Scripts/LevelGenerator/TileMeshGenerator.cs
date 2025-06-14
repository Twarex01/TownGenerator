﻿using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class TileMeshGenerator : MonoBehaviour
{
    private Mesh mesh;
    public Vector3[] vertices;
    private int[] triangles;

    public int VerticesLength { get { return (tileXSize + 1) * (tileZSize + 1); } }
    public int TrianglesLength { get { return tileXSize * tileZSize * 6; } }

    public NoiseGeneratorSettings noiseGeneratorSettings;
    private INoiseGenerator noiseGenerator;

    public int tileXSize;
    public int tileZSize;

    public TileData tileData;

    //TODO: Move to Game Object

    public void Init()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        noiseGenerator = NoiseGeneratorFactory.CreateNoiseGenerator(noiseGeneratorSettings);

        CreateQuad();
        UpdateMesh();
    }

    private void CreateQuad()
    {
        vertices = new Vector3[VerticesLength];

        int i = 0;
        for (int z = 0; z <= tileZSize; z++)
        {
            for (int x = 0; x <= tileXSize; x++)
            {
                var offsetX = gameObject.transform.position.x;
                var offsetZ = gameObject.transform.position.z;

                var noiseValue = Mathf.Clamp(noiseGenerator.Generate(x, z, offsetX, offsetZ), 0.0f, 1.0f);

                if (noiseValue < noiseGeneratorSettings.baseGeneratorSettings.minValue)
                    noiseValue = noiseGeneratorSettings.baseGeneratorSettings.minValue;

                vertices[i] = new Vector3(
                    x,
                    noiseValue * noiseGeneratorSettings.baseGeneratorSettings.multiplier,
                    z);

                i++;
            }
        }

        triangles = new int[TrianglesLength];

        int vert = 0;
        int tris = 0;
        for (int z = 0; z < tileZSize; z++)
        {
            for (int x = 0; x < tileXSize; x++)
            {
                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + tileXSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + tileXSize + 1;
                triangles[tris + 5] = vert + tileXSize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }
    }

    private void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

    public void SetTileData(TileData tileData) 
    {
        //TODO: Check

        //if (tileData != null)
        //    throw new System.Exception("TileData already set!");

        this.tileData = tileData;
    }

    //private void OnDrawGizmos()
    //{
    //    if (vertices == null || vertices.Length == 0)
    //        return;

    //    for (int i = 0; i < vertices.Length; i++)
    //        Gizmos.DrawSphere(vertices[i] + transform.position, .1f);
    //}
}
