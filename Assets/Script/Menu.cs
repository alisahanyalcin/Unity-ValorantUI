using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Color normalColor = new Color(255, 255, 255, 255);
    public Color openColor = new Color(243, 246, 182, 255);
    public string menuName;
    public GameObject menu;
    public bool open;

    public void Open()
    {
        open = true;
        text.color = openColor;
        menu.SetActive(true);
    }

    public void Close()
    {
        open = false;
        text.color = normalColor;
        menu.SetActive(false);
    }
}
