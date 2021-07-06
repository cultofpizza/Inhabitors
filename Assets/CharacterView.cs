using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GD.MinMaxSlider;

public class CharacterView : MonoBehaviour
{
    public Transform CameraHolder;
    public Transform planet;

    public float sensetivity;
    public float Sensetivity
    {
        get { return sensetivity; }
        set
        {
            if (value < 0)
            {
                sensetivity = 0;
                return;
            }

            sensetivity = value;
        }
    }

    public bool ViewYInvetred;

    private Vector3 _cameraRotation;
    private Vector3 _characterRotation;



    [MinMaxSlider(-90f, 90f)]
    [SerializeField] private Vector2 _viewClamp;

    private Input input;
    private Rigidbody rigidbody;
    //private CharacterMovement characterMovement;

    private void Start()
    {
        input = GetComponent<Input>();
        rigidbody = GetComponent<Rigidbody>();


        //characterMovement = GetComponent<CharacterMovement>();
        _cameraRotation = CameraHolder.localRotation.eulerAngles;
        _cameraRotation = transform.localRotation.eulerAngles;

    }
    private void Update()
    {
        CalculateView();
    }


    private void CalculateView()
    {
        //_cameraRotation.x += Sensetivity * (ViewYInvetred ? input._viewInput.y : -input._viewInput.y) * Time.deltaTime;
        //_cameraRotation.x = Mathf.Clamp(_cameraRotation.x, _viewClamp.x, _viewClamp.y);

        //_characterRotation.y += Sensetivity * input._viewInput.x * Time.deltaTime;

        //CameraHolder.localRotation = Quaternion.Euler(_cameraRotation);
        //transform.localRotation = Quaternion.Euler(_characterRotation);
        //transform.localRotation += Quaternion.EulerVector3.up * Sensetivity * input._viewInput.x);

        //transform.localRotation *= Quaternion.Euler(0, 0, Sensetivity * input._viewInput.x);

        //Vector3 planetDirection = (planet.position - transform.position).normalized;
        //Debug.DrawRay(transform.position, planetDirection, Color.red);

        //transform.Rotate((Vector3.up * Sensetivity * input._viewInput.x));

        Vector3 angle = Vector3.up * Sensetivity * input._viewInput.x;

        Quaternion deltaRotation = Quaternion.Euler(angle * Time.deltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);

        _cameraRotation.x += Sensetivity * (ViewYInvetred ? -input._viewInput.y : input._viewInput.y) * Time.deltaTime;
        _cameraRotation.x = Mathf.Clamp(_cameraRotation.x, _viewClamp.x, _viewClamp.y);
        CameraHolder.localEulerAngles = Vector3.left * _cameraRotation.x;
    }

}
