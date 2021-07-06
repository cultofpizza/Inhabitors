using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	private Rigidbody rigidbody;
	private Input input;

    public float jumpForce;

    public Transform planet;

    //public Transform CameraHolder;

    [Header("Movement")]
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _currentSpeed = 0;

    private Vector3 moveAmount;
    Vector3 smoothMoveVelocity;
    private LayerMask groundedMask;
    private bool grounded;

    CharacterController characterController;
    private void Awake()
    {
		rigidbody = GetComponent<Rigidbody>();
        input = GetComponent<Input>();
    }


    private void FixedUpdate()
	{
        Vector3 moveDir = new Vector3(input._movementInput.x, 0, input._movementInput.y);
        Vector3 targetMoveAmount = moveDir;
        moveAmount = Vector3.SmoothDamp(moveAmount, targetMoveAmount, ref smoothMoveVelocity, .15f);

        Vector3 localMove = transform.TransformDirection(moveAmount) * _movementSpeed * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + localMove);

        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1 + .1f, groundedMask))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

    }

    public void Jump()
    {
        rigidbody.AddForce(transform.up * jumpForce, ForceMode.VelocityChange);
    }
}
