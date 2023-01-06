using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    public int HealthValue = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<EntityHealth>().CurrentHealth += HealthValue;
            Destroy(gameObject);
        }
    }
}
