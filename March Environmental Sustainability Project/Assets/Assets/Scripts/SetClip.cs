using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetClip : MonoBehaviour
{

    [SerializeField] TMP_InputField txt;
    [SerializeField] GameObject screen1, screen2, enterscreen;

    public void Start()
    {
        
    }

    public void Update()
    {
        
    }
    public void Click()
    {
        string text = txt.text;
        

        print(text);

        if (text == "Bishop Ranch Mall")
        {            
            screen1.SetActive(true); screen2.SetActive(false);
        }
        else if (text == "Bellingham Park")
        {
            screen2.SetActive(true); screen1.SetActive(false);
        }

        enterscreen.SetActive(false);
    }
}
