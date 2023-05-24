using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    public Vector2 centerOfMass2;
    public bool awake;
    public Rigidbody2D rb;
    public float radius = .5f;

    private void Start()
    {
     
    }

    private void Update()
    {
        rb.centerOfMass = centerOfMass2;
        rb.WakeUp();
        awake = !rb.IsSleeping();
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + transform.rotation * centerOfMass2,radius);
    }
}
