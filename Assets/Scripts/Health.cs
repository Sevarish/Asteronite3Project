using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float CurrentHealt { get; set; }
    public float MaxHealt { get; set; }

    public Slider healthbar;

    // Use this for initialization
    void Start()
    {
        MaxHealt = GameObject.Find("Player").GetComponent<LoseHealthOnHit>().maxHealth;
        CurrentHealt = MaxHealt;

        healthbar.value = CalculateHealth();
    }

    public void DealDamage(float damageValue)
    {
        CurrentHealt -= damageValue;
        healthbar.value = CalculateHealth();

        if (CurrentHealt <= 0)
            Die();
    }
    public void Heal(float healValue)
    {
        CurrentHealt += healValue;
        healthbar.value = CalculateHealth();

    }

    float CalculateHealth()
    {
        return CurrentHealt / MaxHealt;
    }

    void Die()
    {
        CurrentHealt = 0;
        Debug.Log("You died.");
    }
}