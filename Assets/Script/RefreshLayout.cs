using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace alisahanyalcin
{
    public class RefreshLayout : MonoBehaviour
    {
        [SerializeField] private HorizontalLayoutGroup layoutGroup;

        private void Awake()
        {
            Invoke(nameof(Refresh), 0.001f);
        }

        private void Refresh()
        {
            layoutGroup.childControlHeight = true;
        }
    }
}
