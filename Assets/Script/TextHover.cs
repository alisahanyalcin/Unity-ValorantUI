using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextHover : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    public void OnHoverColor()
    {
        text.color = Color.white;
    }
    
    public void OnExitColor()
    {
        text.color = Color.black;
    }
    
    public void ClickColor()
    {
        text.color = Color.black;
    }
}
