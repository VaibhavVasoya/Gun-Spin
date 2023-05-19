using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPack : MonoBehaviour
{
    public GameObject[] items;
    public Transform referenceposition;

    
   

    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Camera")) {
           // Debug.Log("befor " + transform.position);
            transform.position = new Vector2(0, referenceposition.position.y + 5);
            //Debug.Log(transform.position);

           foreach (GameObject i in   items )
          {
            i.SetActive(true);
            
          }
            //Debug.Log(other.tag);
            
        }


      






    }


}

