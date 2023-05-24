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
    public  int Bulletcount = 2000;
    public int CurrentGun = 0;
    [SerializeField] Sprite[] Guns;
    private SpriteRenderer Gunsprite;
    public float shoottime = 0f;
    public bool isbuyed;

   

    private void Awake()
    {
        inst = this;
    }
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
        rb.gravityScale = 0;
        Gunsprite = GetComponent<SpriteRenderer>();
        StartCoroutine(Doubleshoot());
        Debug.Log("Hii");
    }

    //    IEnumerator Shoot()
    // {        
    // while (isplaying == true)
    //     Debug.Log("True");
    // { 
    //   if (Input.touchCount > 0 || Input.GetMouseButton(0))
    //   {
    //   Touch touch = Input.GetTouch(0);
    //
    //   if (touch.phase == TouchPhase.Stationary || Input.GetMouseButton(0))
    //   {
    //           Debug.Log("Button Pressed");
    //    if (Bulletcount > 0)
    //    {
    //
    //        rb.AddForce(-transform.right * RecoilForce);
    //        float a = Vector2.SignedAngle(Vector2.up, transform.right);
    //        ParticleSystem.Play();
    //
    //        if (a > 0)
    //        {
    //            rb.AddTorque(Torque);
    //
    //        }
    //        else
    //        {
    //            rb.AddTorque(-Torque);
    //
    //        }
    //    }
    //    Bulletcount -= 1;
    //
    //  }
    //     }
    // yield return new WaitForSeconds(shoottime);
    // }

    // }

  


    public  IEnumerator Doubleshoot()
    {
        
        while (true)
        {
            if ( Input.touchCount > 0 || Input.GetMouseButton(0))
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Ended)
                {
                    
                    if (Bulletcount > 0)
                    {
                        rb.AddForce(-transform.right * RecoilForce,ForceMode2D.Impulse);
                        float a = Vector2.SignedAngle(Vector2.up, transform.right);
                        ParticleSystem.Play();
                        AudioManager.inst.OnplaySound("Gun");

                        if (a > 0)
                        {
                            rb.AddTorque(Torque);

                        }
                        else
                        {
                            rb.AddTorque(-Torque);

                        }
                    }
                }
                Bulletcount -= 1;

            }
            yield return new WaitForSeconds(shoottime);
      

        }
        }


   

    public void GameOnstart()
    {
        isplaying = true;
        rb.gravityScale = .5f;
        rb.AddForce(Vector2.up * StartForce);
        if (isbuyed)
        {
            Debug.Log("Sprite Changed");
            Gunsprite.sprite = Guns[CurrentGun];
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Right"))
        {
            transform.position = new Vector3(-3.8f, transform.position.y, transform.position.z);
        }

        else if ( other.gameObject.CompareTag("Left"))
        {
            transform.position = new Vector3(3.8f, transform.position.y, transform.position.z);
        }

       if (other.gameObject.CompareTag("Coin"))
       {
            AudioManager.inst.OnplaySound("Coin");
           ScoreManager.instance.AddCoin();
           other.gameObject.SetActive(false);
       }

       if (other.gameObject.CompareTag("Powerup"))
        {
            AudioManager.inst.OnplaySound("PowerUp");       
            rb.velocity = (Vector2.up * ExtraForce);
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("EndLine"))
        {
            AudioManager.inst.OnplaySound("Game Over");
            ScoreManager.instance.UpdateHighest();
            ScreenManager.instance.showNextScreen(ScreenList.GameOverScreen);
            gameObject.SetActive(false);
       
        }
      
    }
}


   // private void OnchangeSprite()
   // {
   //     Gunsprite.sprite = Guns[CurrentGun];
   // }
    
   //private void FixedUpdate()
   //{
   //   //GunMovement();
   //    //StartCoroutine(Shoot());
   //  // OnchangeSprite();
   //   
   //    
   //}