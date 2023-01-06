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

public class AnimatorBinding : MonoBehaviour
{
    [SerializeField] InputActionReference _move;
    [SerializeField] InputActionReference _attack;
    [SerializeField] Animator anim;
    public event Action OnStartMove;
    // Start is called before the first frame update
    void Start()
    {
        _move.action.started += StartMove;
        _move.action.canceled += StopMove;
        _attack.action.started += StartAttack;
        _attack.action.canceled += StopAttack;
    }
    private void OnDestroy()
    {
        _move.action.started -= StartMove;
        _move.action.canceled -= StopMove;
        _attack.action.started -= StartAttack;
        _attack.action.canceled -= StopAttack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void StartMove(InputAction.CallbackContext obj)
    {
        anim.SetBool("Walking", true);
    }

    private void StartAttack(InputAction.CallbackContext obj)
    {
        anim.SetBool("Attack", true);
    }
    private void StopAttack(InputAction.CallbackContext obj)
    {
        anim.SetBool("Attack", false);
    }
    private void StopMove(InputAction.CallbackContext obj)
    {
        anim.SetBool("Walking", false);
    }
}
