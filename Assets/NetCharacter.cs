using MLAPI;
using MLAPI.Messaging;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetCharacter : NetworkBehaviour
{
    private CharacterMovement movement;
    [SerializeField] private bool hasMovement;

    private CharacterView view;
    [SerializeField] private bool hasView;

    private Camera camera;
    private AudioListener audioListener;
    private GravityBody gravityBody;

    private void Awake()
    {
        movement = GetComponent<CharacterMovement>();
        view = GetComponent<CharacterView>();
        camera = GetComponentInChildren<Camera>();
        audioListener = GetComponentInChildren<AudioListener>();
    }

    private void Start()
    {

        if (IsLocalPlayer)
        {
            gravityBody = gameObject.AddComponent<GravityBody>();
            gravityBody.enabled = true;


            camera.enabled = true;

            if (hasMovement)
            {
                movement.enabled = true;
            }
            if (hasView)
            {
                view.enabled = true;
            }
        }
        else
        {
            camera.enabled = false;
            audioListener.enabled = false;
            if (hasMovement)
            {
                movement.enabled = false;
            }
            if (hasView)
            {
                view.enabled = false;
            }
        }
    }

    [ServerRpc]
    void SubmitPositionRequestServerRpc(ServerRpcParams rpcParams = default)
    {

    }

}
