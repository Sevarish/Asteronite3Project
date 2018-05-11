using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHealthOnHit : MonoBehaviour
{
    public int maxHealth = 500;
    public int health;
    private void Start()
    {
        health = maxHealth;
    }
    void OnCollisionEnter(Collision other)
    {

        GameObject.Find("Player").GetComponent<Health>().DealDamage(12);

    }
}

