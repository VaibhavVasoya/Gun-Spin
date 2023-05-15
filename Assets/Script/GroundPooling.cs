using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPooling : MonoBehaviour
{
    public static GroundPooling inst;
    private List<GameObject> gameObjects = new List<GameObject>();
    private int amountpool = 2;
    [SerializeField] private GameObject ground;


    private void Awake()
    {
        inst = this;
    }

    public void Start()
    {
        for (int i = 0; i < amountpool; i++)
        {
            GameObject obj = Instantiate(ground);
            obj.SetActive(false);
            gameObjects.Add(obj);
        }
    }

    public GameObject GetgameObjects()
    {
        for (int i = 0; i< gameObjects.Count; i++)
        {
            if (!gameObjects[i].activeInHierarchy)
            {
                return gameObjects[i];
            }

        }

        return null;
    }
}
