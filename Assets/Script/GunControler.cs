using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GunControler : MonoBehaviour
{
    private Rigidbody2D rb;
    public ParticleSystem ParticleSystem;
    public float RecoilForce;
    public float Torque;
    public float ExtraForce = 100;
    public float StartForce;
    public bool isplaying = false;
    public static GunControler inst;
    public  int Bulletcount = 20;

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
        //Indicator.inst.UpdateText(Bulletcount);
    }

    public void GunMovement()
    {
        if (Input.touchCount > 0) {
         if (isplaying == true )
            {
                if (Input.GetMouseButtonDown(0))

                {
                if (Bulletcount > 0)
                { 
                    rb.AddForce(-transform.right * RecoilForce);
                    float a = Vector2.SignedAngle(Vector2.up, transform.right);
                    ParticleSystem.Play();
                    
                    
                   
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
   }
    
    public void Gamestate()
    {
        
        rb.gravityScale = 1f;
        rb.AddForce(Vector2.up * StartForce);
       
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Right"))
        {
            transform.position = new Vector3(-3.5f, transform.position.y, transform.position.z);
        }

        if (other.gameObject.CompareTag("Left"))
        {
            transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);
        }

       if (other.gameObject.CompareTag("Coin"))
       {
           ScoreManager.instance.AddCoin();
            other.gameObject.SetActive(false);
            

        }
       if (other.gameObject.CompareTag("Powerup"))
        {           
            rb.velocity = (Vector2.up * ExtraForce);

            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("EndLine"))
        {
            ScoreManager.instance.UpdateHighest();
            ScreenManager.instance.showNextScreen(ScreenList.GameOverScreen);
            gameObject.SetActive(false);
           
           
          
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            Bulletcount += 5;
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
        }


        



      //  if (other.gameObject.CompareTag("GroundPoller"))
      //  {
      //      GroundPooling.inst.GetgameObjects();
      //  }

    }
}

