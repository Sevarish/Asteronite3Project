using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHealthOnHit : MonoBehaviour
{
    public float health = 10;
    void OnCollisionEnter(Collision other)
    {
        health--;
        Debug.Log(health);
        
        if (health < 1)
        {
            Destroy(this.gameObject);
        }

    }
}

