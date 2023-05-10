using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunControler : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] Bullet bullets;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    public void Update()
    {

       Debug.Log(Vector2.SignedAngle(Vector2.up,rb.transform.right));

    }




    private void FixedUpdate()
    {
        GunMovement();
    }

    public void GunMovement()
    {
        if (Input.GetMouseButtonDown(0) && Instantiate(bullets, rb.transform.position, rb.transform.rotation))
        {
             rb.velocity = new Vector2(0f, 5f);
             rb.AddTorque(2f);
         
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

