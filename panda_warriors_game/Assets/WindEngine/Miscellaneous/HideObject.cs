using UnityEngine;

namespace WindEngine.Miscellaneous
{
    [AddComponentMenu("WindEngine/Miscellaneous/HideObject")]
    public class HideObject : MonoBehaviour
    {
        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
