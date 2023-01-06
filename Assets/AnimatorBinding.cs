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
    [SerializeField] Animator anim;
    public event Action OnStartMove;
    // Start is called before the first frame update
    void Start()
    {
        _move.action.started += StartMove;
        _move.action.performed += UpdateMove;
        _move.action.canceled += StopMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void StartMove(InputAction.CallbackContext obj)
    {
        anim.SetBool("Walking", true);
    }

    private void UpdateMove(InputAction.CallbackContext obj)
    {
        print(2);
    }
    private void StopMove(InputAction.CallbackContext obj)
    {
        anim.SetBool("Walking", false);
    }
}
