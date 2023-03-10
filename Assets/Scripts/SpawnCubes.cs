using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject[] cubes;
    public List<Transform> spawnPoints;

    void Start()
    {
        spawnPoints = new List<Transform>(spawnPoints);
        Spawn();
    }

    void Spawn()
    {
        for( int i = 0; i < cubes.Length; i++)
        {
            var spawn = Random.Range(0, spawnPoints.Count);
            Instantiate(cubes[i], spawnPoints[spawn].transform.position, Quaternion.identity);
            spawnPoints.RemoveAt(spawn);
        }
    }
}
