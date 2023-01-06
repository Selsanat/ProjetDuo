using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    public int PowerUpValue = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<EntityHealth>().MaxHealth += PowerUpValue;
            other.gameObject.GetComponent<EntityHealth>().CurrentHealth += PowerUpValue;
            Destroy(gameObject);
        }
    }
}
