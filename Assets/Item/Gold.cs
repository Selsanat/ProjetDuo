using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    public int GoldValue = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<EntityGold>().CurrentGold += GoldValue;
            GoldUI._golds = other.gameObject.GetComponent<EntityGold>().CurrentGold;
            Destroy(gameObject);
        }
    }
}
