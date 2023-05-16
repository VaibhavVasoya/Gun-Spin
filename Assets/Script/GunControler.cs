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
    public bool isplaying = false;
    public static GunControler inst;
    public static int Bulletcount = 0;

    public int CurrentGun = 0;
    [SerializeField] Sprite[] Guns;
    private SpriteRenderer Gunsprite;


    private void Awake()
    {
        inst = this;
    }
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
        rb.gravityScale = 0;
        Gunsprite = GetComponent<SpriteRenderer>(); 
       
    }
     public void Changesprite()
    {
        Gunsprite.sprite = Guns[CurrentGun];
    }

    private void Update()
    {        
        GunMovement();
        Changesprite();
    }

    public void GunMovement()
    {
         if (isplaying == true )
            {
                if (Input.GetMouseButtonDown(0))

                {
                if (Bulletcount > 0)
                { 
                    rb.AddForce(-transform.right * RecoilForce);
                    float a = Vector2.SignedAngle(Vector2.up, transform.right);
                    if (a > 0)
                    {
                        rb.AddTorque(Torque);

                    }
                    else
                    {
                        rb.AddTorque(-Torque);

                    }
                }
                   Bulletcount -= 1;
            }            
        }
    }
    
    public void Gamestate()
    {
        
        rb.gravityScale = 0.3f;
        rb.AddForce(Vector2.up * StartForce);
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
           
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("EndLine"))
        {
            ScreenManager.instance.showNextScreen(ScreenList.GameOverScreen);
          
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            Bulletcount += 1;
            Destroy(other.gameObject);           
       
        }
      //  if (other.gameObject.CompareTag("GroundPoller"))
      //  {
      //      GroundPooling.inst.GetgameObjects();
      //  }

    }
}

