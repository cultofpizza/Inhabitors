using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    public Transform CameraHolder;
    public CharacterMesh mesh;

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



    [SerializeField] private Vector2 _viewClamp;

    private Rigidbody _rigidbody;

    private DefaultInput _defaultInput;
    private Vector2 _viewInput;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _cameraRotation = CameraHolder.localRotation.eulerAngles;
        _cameraRotation = transform.localRotation.eulerAngles;

        _defaultInput = new DefaultInput();
        BindInput();

        mesh = GetComponentInChildren<CharacterMesh>();
        mesh.gameObject.SetActive(false);
    }

    private void BindInput()
    {
        _defaultInput.Character.View.performed += e => _viewInput = e.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        _defaultInput.Enable();
    }

    private void OnDisable()
    {
        _defaultInput.Disable();

        _viewInput = Vector3.zero;
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

        Vector3 angle = Vector3.up * Sensetivity * _viewInput.x;

        Quaternion deltaRotation = Quaternion.Euler(angle * Time.deltaTime);
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);

        _cameraRotation.x += Sensetivity * (ViewYInvetred ? -_viewInput.y : _viewInput.y) * Time.deltaTime;
        _cameraRotation.x = Mathf.Clamp(_cameraRotation.x, _viewClamp.x, _viewClamp.y);
        CameraHolder.localEulerAngles = Vector3.left * _cameraRotation.x;
    }

}
