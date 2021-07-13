using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class CharacterMovement : NetworkBehaviour
{
    private Rigidbody rigidbody;

    public float jumpForce;

    public Transform planet;

    public Transform _feet;
    [SerializeField] private float _feetRadius;

    //public Transform CameraHolder;

    [Header("Movement")]
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _currentSpeed = 0;

    private Vector3 moveAmount;
    Vector3 smoothMoveVelocity;
    public LayerMask _groundMask;
    private bool isGrounded;

    [SerializeField] private bool IsGrounded
    {
        get { return Physics.CheckSphere(_feet.position + Vector3.up * (_feetRadius - 0.05f), _feetRadius, _groundMask); }
    }


    private DefaultInput _defaultInput;
    private Vector2 _movementInput;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        _defaultInput = new DefaultInput();
        BindInput();
    }



    private void BindInput()
    {
        _defaultInput.Character.Movement.performed += e => _movementInput = e.ReadValue<Vector2>();

        _defaultInput.Character.Jump.performed += e => Jump();

    }

    private void OnEnable()
    {
        _defaultInput.Enable();
    }

    private void OnDisable()
    {
        _defaultInput.Disable();
        _movementInput = Vector3.zero;
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = new Vector3(_movementInput.x, 0, _movementInput.y);
        Vector3 targetMoveAmount = moveDir;
        moveAmount = Vector3.SmoothDamp(moveAmount, targetMoveAmount, ref smoothMoveVelocity, .15f);

        Vector3 localMove = transform.TransformDirection(moveAmount) * _movementSpeed * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + localMove);
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawSphere(_feet.position + Vector3.up * (_feetRadius - 0.05f), _feetRadius);
    //}

    public void Jump()
    {
        if (IsGrounded)
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode.VelocityChange);
        }

    }
}
