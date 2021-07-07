using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Input input;

    public float jumpForce;

    public Transform planet;
    public Transform feet;

    //public Transform CameraHolder;

    [Header("Movement")]
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _currentSpeed = 0;

    private Vector3 moveAmount;
    Vector3 smoothMoveVelocity;
    public LayerMask groundMask;
    private bool isGrounded;

    CharacterController characterController;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        input = GetComponent<Input>();
    }

    private void FixedUpdate()
    {
        Ray ray = new Ray(feet.position + transform.up * 0.05f, -transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, 0.1f, groundMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        Vector3 moveDir = new Vector3(input._movementInput.x, 0, input._movementInput.y);
        Vector3 targetMoveAmount = moveDir;
        moveAmount = Vector3.SmoothDamp(moveAmount, targetMoveAmount, ref smoothMoveVelocity, .15f);

        Vector3 localMove = transform.TransformDirection(moveAmount) * _movementSpeed * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + localMove);


    }

    public void Jump()
    {
        if (isGrounded)
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode.VelocityChange);
        }

    }
}
