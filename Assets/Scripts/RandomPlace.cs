using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlace : MonoBehaviour
{
    public Transform planet;
    public LayerMask groundMask;
    public GameObject prefab;

    Vector3 pointNormalized;

    Vector3 point;

    Vector3 direction;

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(planet.position, point.y);
    }

    private void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            pointNormalized = Random.insideUnitSphere;

            point = pointNormalized * planet.localScale.y * 2;

            direction = planet.position - point;


            RaycastHit hit;
            Physics.Raycast(point, direction, out hit, 999, groundMask);

            print(i +" "+ Vector3.Angle(hit.normal, new Ray(point, direction).direction));



            Vector3 gravityUp = (prefab.transform.position - transform.position).normalized;
            Vector3 localUp = -prefab.transform.up;

            // Allign bodies up axis with the centre of planet
            prefab.transform.rotation = Quaternion.FromToRotation(localUp, gravityUp) * prefab.transform.rotation;

            Instantiate(prefab, hit.point, Quaternion.FromToRotation(localUp, new Ray(point, direction).direction) * prefab.transform.rotation);
        }
    }
}
