using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] int _maxGold = 5000;
    public int CurrentGold = 0;
    private void Awake()
    {
        CurrentGold = 0;
    }
}


