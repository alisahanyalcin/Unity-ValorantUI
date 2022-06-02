using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Singleton;

    [SerializeField] private Menu[] menus;

    private void Awake()
    {
        if (Singleton == null)
            Singleton = this;
        else
            Destroy(this);
    }

    public void OpenMenu(string menuName)
    {
        foreach (var t in menus)
        {
            if(t.menuName == menuName)
                t.Open();
            else if(t.open)
                CloseMenu(t);
        }
    }

    public void OpenMenu(Menu menu)
    {
        foreach (var t in menus)
        {
            if(t.open)
                CloseMenu(t);
        }

        menu.Open();
    }

    private void CloseMenu(Menu menu)
    {
        menu.Close();
    }
}
