using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{

    [SerializeField] int _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<EntityHealth>().CurrentHealth -= _damage;
            if (other.gameObject.GetComponent<EntityHealth>().CurrentHealth <=0)
            {
                Destroy(other.gameObject);
            }
        }
    }

}

