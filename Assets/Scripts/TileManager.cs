using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 30;
    public int numberOfTiles = 5;
    private List<GameObject> activeTiles = new List<GameObject>();
    public Transform joueurTransform;
    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if(i == 0)
                SpawnTile(i);
            else
                SpawnTile(Random.Range(1, tilePrefabs.Length));
        }
    }

    
    void Update()
    {
        if (joueurTransform.position.z - (tileLength+5) > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }

    public void SpawnTile(int routeIndex)
    {
        GameObject tile = Instantiate(tilePrefabs[routeIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(tile);
        zSpawn += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
