using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunControler : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public float RecoilForce;
    public float Torque;
    public float ExtraForce = 100;
    public float StartForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * StartForce);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Right"))
        {
            transform.position = new Vector3(-2f, transform.position.y, transform.position.z);
        }

        if (other.gameObject.CompareTag("Left"))
        {
            transform.position = new Vector3(2f, transform.position.y, transform.position.z);
        }

       if (other.gameObject.CompareTag("Coin"))
       {
           ScoreManager.instance.ChangeScore();
           Destroy(other.gameObject);         
      
       }
       if (other.gameObject.CompareTag("Powerup"))
        {           
            rb.velocity = (Vector2.up * ExtraForce);
            Debug.Log("powerup");
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("EndLine"))
        {
            ScreenManager.instance.showNextScreen(ScreenList.GameOverScreen);
            Debug.Log("Welcom");
        }


    }
}

