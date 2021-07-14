using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MLAPI;

public class Compass : MonoBehaviour
{
    public GameObject markerPrefab;

    public Transform[] targets;
    public Sprite marker;

    public TextMeshProUGUI text;
    public RawImage image;
    private Transform character;
    private Transform planet;

    float compassUnit;

    private void Start()
    {
        character = NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject.gameObject.GetComponent<Transform>();
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<Transform>();

        compassUnit = image.rectTransform.rect.width / 360f;
    }

    private void Update()
    {
        image.uvRect = new Rect((character.localEulerAngles.x + character.localEulerAngles.y + character.localEulerAngles.z) / 3 / 360, 0, 1, 1);

        Vector3 forward = character.transform.forward;

        forward.y = 0;

        float headingAngle = Quaternion.LookRotation(forward).eulerAngles.y;


        float longitude = Vector3.Angle(character.up, planet.up);
        float latitude = Vector3.Angle(character.up, planet.forward);

        float length = 2 * Mathf.PI * planet.localScale.y * Vector3.Angle(character.up, planet.up) / 360;

        int displayLongitude = (int)(longitude - 90);
        int displayLatitude = (int)(latitude - 90);

        text.text = string.Concat(
            displayLongitude, " ", displayLatitude, " ",
            (displayLongitude < 0 ? "N" : "S"),
            (displayLatitude < 0 ? "W" : "E"), " ", length);

        foreach (var target in targets)
        {
            Vector3 vector = target.position - character.position;
            Vector3.Angle(character.forward, vector);
        }

    }

    private void AddMarker()
    {
        GameObject marker = Instantiate(markerPrefab, image.transform);
    }


    private Vector2 GetPosOnCompass()
    {
        return new Vector2(0, 0);
    }
}
