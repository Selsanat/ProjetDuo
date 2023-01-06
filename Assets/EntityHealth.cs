using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    public int MaxHealth = 100;

    public int CurrentHealth = 100 ;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    



}
