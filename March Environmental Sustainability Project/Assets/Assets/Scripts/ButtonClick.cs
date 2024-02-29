using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public void Click()
    {
        Cursor.visible = !Cursor.visible;
    }
}
