using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPack : MonoBehaviour
{
    public GameObject[] items;
    public Transform referenceposition;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Camera"))
        {
            transform.position = new Vector2(0, referenceposition.position.y + 5) ;
            collision.gameObject.SetActive(true);
        }

            Debug.Log(transform.position = new Vector2(0, referenceposition.position.y + 5));
            Debug.Log("is");


    }


}

