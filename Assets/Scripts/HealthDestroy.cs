using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDestroy : MonoBehaviour {
    public int health = 10;
    void OnCollisionEnter(Collision other)
    {
        health--;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
