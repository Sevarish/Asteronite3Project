using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{


    public GameObject cubePrefab;
    // Use this for initialization
    private float spawnTimer = 0;
    public float spawnThreshold = 5F;


    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
        }
        //print(spawnTimer);

    }
    private void SpawnCube()
    {

        Vector3 spawnPoisition = new Vector3(Random.Range(-1000f, 1000f), Random.Range(-200f, 800f), Random.Range(-1000f, 1000f));
        Instantiate(cubePrefab, spawnPoisition, Quaternion.identity);

        spawnTimer = 0;
    }


}