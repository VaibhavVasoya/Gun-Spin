using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicator : MonoBehaviour
{
    public Text Text;

    public void UpdateText(int count)
    {
        Text.text = " Text :- " + count;

    }


    public static Indicator inst;

    private void Awake()
    {
        inst = this;
    }
}
