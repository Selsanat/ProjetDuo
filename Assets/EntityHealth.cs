using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    public int MaxHealth;

    public int CurrentHealth ;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    private void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
                if (CurrentHealth >= MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }

    



}
