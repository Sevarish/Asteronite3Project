using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour {

    public GameObject cubePrefab;
    public int asteroidAmount = 50;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < asteroidAmount; i++)
        {
            Vector3 spawnPoisition = new Vector3(Random.Range(-1000f, 1000f), Random.Range(-200f, 800f), Random.Range(-1000f, 1000f));
            Instantiate(cubePrefab, spawnPoisition, Quaternion.identity);
        }
    }
	
	
}
