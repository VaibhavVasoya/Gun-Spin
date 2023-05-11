using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunControler : MonoBehaviour
{
    private Rigidbody2D rb;
    public float RecoilForce;
    public float Torque;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            Debug.Log(Vector2.SignedAngle(Vector2.up,transform.right));
          
        }
    }




    private void FixedUpdate()
    {
        GunMovement();
    }

    public void GunMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {            
            rb.AddForce(-transform.right * RecoilForce);
            float a = Vector2.SignedAngle(Vector2.up, transform.right);
            if (a > 0)
            {
                rb.AddTorque(Torque);
               // rb.SetRotation(a);
            }
            else
            {
                rb.AddTorque(-Torque);
               // rb.SetRotation(-a);
            }
          
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Right"))
        {
            transform.position = new Vector3(-2f, transform.position.y, transform.position.z);
        }

        if (collision.gameObject.CompareTag("Left"))
        {
            transform.position = new Vector3(2f, transform.position.y, transform.position.z);
        }
    }

}

