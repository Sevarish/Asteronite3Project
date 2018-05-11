using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHitHealth : MonoBehaviour
{
    int health = 60;

    void OnCollisionEnter(Collision other)
    {
        health--;
        Debug.Log("Health: " + health);
        if (health < 1)
        {
            Debug.Log("Destroyed");
            Destroy(this.gameObject);
        }
        

    }
}

