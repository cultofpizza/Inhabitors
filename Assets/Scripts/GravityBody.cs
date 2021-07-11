using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class GravityBody : MonoBehaviour
{

    GravityAttractor planet;
    Rigidbody rigidbody;

    public bool alighnBodyToPlanet = true;

    void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
        rigidbody = GetComponent<Rigidbody>();

        // Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
        rigidbody.useGravity = false;

        if (alighnBodyToPlanet)
        {
            rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }

    }

    void FixedUpdate()
    {

        if (alighnBodyToPlanet)
        {
            // Allow this body to be influenced by planet's gravity
            planet.AttractAligned(rigidbody);
        }
        else
        {
            planet.AttractPhysics(rigidbody);
        }

    }
}