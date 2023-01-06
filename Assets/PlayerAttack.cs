using Cinemachine;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField] InputActionReference _attack;
    public int _damage = 50;

    public event Action OnStartAttack;
    public event Action<int> OnHealthUpdate;

        // Event pour les GD
    [SerializeField] UnityEvent _onEvent;
    [SerializeField] UnityEvent _onEventPost;


    private void Start()
    {
        _attack.action.started += StartAttack;
        _attack.action.performed += UpdateAttack;
        _attack.action.canceled += StopAttack;
    }

    private void OnDestroy()
    {
        _attack.action.started -= StartAttack;
        _attack.action.performed -= UpdateAttack;
        _attack.action.canceled -= StopAttack;
    }

    private void StartAttack(InputAction.CallbackContext obj)
    {
        Debug.Log("StartAttack");
    }

    private void UpdateAttack(InputAction.CallbackContext obj)
    {
        Debug.Log("UpdateAttack");
    }

    private void StopAttack(InputAction.CallbackContext obj)
    {
        Debug.Log("StopAttack");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EntityHealth>().CurrentHealth -= (int)_damage;
        }
    }

}




