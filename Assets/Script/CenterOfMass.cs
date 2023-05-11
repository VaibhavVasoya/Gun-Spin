using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    public Vector2 centerOfMass2;
    public bool awake;
    protected Rigidbody2D r;

    private void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        r.centerOfMass = centerOfMass2;
        r.WakeUp();
        awake = !r.IsSleeping();
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + transform.rotation * centerOfMass2,.2f);
    }
}
