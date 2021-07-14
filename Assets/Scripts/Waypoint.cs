using MLAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    public Image marker;

    public TextMeshProUGUI distanceText;

    public Transform character;
    public Transform target;
    public Camera camera;


    public float maxDistance;


    private void Start()
    {
        character = NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject.gameObject.GetComponent<Transform>();
        marker = GetComponent<Image>();
        distanceText = GetComponentInChildren<TextMeshProUGUI>();
        camera = character.gameObject.GetComponentInChildren<Camera>();
    }

    private void Update()
    {
        if (target == null) Destroy(gameObject);

        CheckOnScreen();
        GetDistance();

    }

    private void GetDistance()
    {
        float distance = Vector3.Distance(character.position, target.position);
        distanceText.text = distance.ToString("f1") + "m";

        if (distance < maxDistance)
        {
            ToggleUI(false);
        }
        else
        {
            ToggleUI(true);
        }
    }

    private void CheckOnScreen()
    {

        float thing = Vector3.Dot((target.position - camera.transform.position).normalized, camera.transform.forward);

        if (thing <= 0)
        {
            ToggleUI(false);
        }
        else
        {
            transform.position = camera.WorldToScreenPoint(target.position);
            ToggleUI(true);
        }
    }

    private void ToggleUI(bool value)
    {
        marker.enabled = value;
        distanceText.enabled = value;
    }
}
