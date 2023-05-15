using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
   
    public Transform player;

    private void LateUpdate()
    {
        if (transform.position.y < player.position.y)
        {
            transform.position = new Vector3(0, player.position.y, -10);            
        }       
      
    }
   
}
