using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenWeblink(string url)
    {
        Application.OpenURL(url);
    }
}
