using UnityEngine;

namespace WindEngine.Localization
{
    [System.Serializable]
    public class LocalizationData
    {
        public LocalizationItem[] items;
    }

    [System.Serializable]
    public class LocalizationItem
    {
        public string key;
        [TextArea]
        public string value;
    }
}