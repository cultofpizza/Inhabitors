using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    [HideInInspector] public DefaultInput _defaultInput;
    [HideInInspector] public Vector2 _movementInput;
    [HideInInspector] public Vector2 _viewInput;

    private CharacterMovement characterMovement;

    private void Awake()
    {
        BindInput();

        characterMovement = GetComponent<CharacterMovement>();
    }

    private void OnEnable()
    {
        _defaultInput.Enable();

    }

    private void OnDisable()
    {
        _defaultInput.Disable();

    }

    private void BindInput()
    {
        _defaultInput = new DefaultInput();
        _defaultInput.Character.View.performed += e => _viewInput = e.ReadValue<Vector2>();

        _defaultInput.Items.Equip.performed += PickUp;

    }

    private void PickUp(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void StopCrawl()
    {
        throw new NotImplementedException();
    }

    private void Crawl()
    {
        throw new NotImplementedException();
    }

    private void Crouch()
    {
        throw new NotImplementedException();
    }

    private void StopCrouch()
    {
        throw new NotImplementedException();
    }

    private void Jump()
    {
        characterMovement.Jump();
    }
}
