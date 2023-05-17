using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Poolitem
{
    public GameObject Prefab;
    public int amount;
}

public class GroundPooling : MonoBehaviour
{
    public static GroundPooling inst;
    public List<Poolitem> poolitems;
    public List<GameObject> pooleditems;



    private void Awake()
    {
        inst = this;
    }


    public GameObject Get(string tag)
    {
        for (int i = 0; i < pooleditems.Count; i++)
        {
            if (pooleditems[i].activeInHierarchy && pooleditems[i].tag == tag) 
            {
                return pooleditems[i];
            }
        }
        return null;
    }

    public void start()
    {
        pooleditems = new List<GameObject>();
        foreach (Poolitem item in poolitems)
        {
            for (int i = 0; i < item.amount; i++)
            {
                GameObject obj = Instantiate(item.Prefab);
                obj.SetActive(false);
                pooleditems.Add(obj);
            }
        }
    }
}