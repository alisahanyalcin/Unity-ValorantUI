using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Color openColor = new Color(243, 246, 182, 255);
    public string menuName;
    public GameObject menu;
    public bool open;

    public void Update()
    {
        if (open)
        {
            text.color = openColor;
        }
    }

    public void Open()
    {
        open = true;
        menu.SetActive(true);
    }

    public void Close()
    {
        open = false;
        menu.SetActive(false);
    }
}
