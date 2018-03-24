﻿using UnityEngine;
using UnityEngine.UI;

namespace WindEngine.Localization
{
    public class LocalizedText : MonoBehaviour
    {
        public string key;

        void Start()
        {
            Text text = GetComponent<Text>();
            text.text = LocalizationManager.instance.GetLocalizedValue(key);
        }

    }
}