using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletspeed = 10f;
   



    private void Awake()
    {
        
    }



    void Update()
    {
        {
            transform.Translate(Vector2.right * bulletspeed * Time.deltaTime);

           
        }
    }
}
