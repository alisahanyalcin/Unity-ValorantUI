using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace alisahanyalcin
{
    public class RefreshLayout : MonoBehaviour
    {
        [SerializeField] private HorizontalLayoutGroup horizontalLayout;
        [SerializeField] private VerticalLayoutGroup verticalLayout;

        private void Awake()
        {
            Invoke(nameof(Refresh), 0.001f);
        }
        
        private void Refresh()
        {
            if (horizontalLayout != null)
            {
                horizontalLayout.childControlHeight = true;
            }
            
            if (verticalLayout != null)
            {
                verticalLayout.childControlHeight = true;
            }
        }
    }
}
