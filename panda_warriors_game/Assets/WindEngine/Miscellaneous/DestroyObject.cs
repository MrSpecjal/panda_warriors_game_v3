using UnityEngine;

namespace WindEngine.Miscellaneous
{
    [AddComponentMenu("WindEngine/Miscellaneous/DestroyObject")]
    public class DestroyObject : MonoBehaviour
    {
        public void DestroySelfGameObject()
        {
            GameObject.Destroy(gameObject);
        }

        public void DestroyOtherGameObject(GameObject otherTarget)
        {
            GameObject.Destroy(otherTarget);
        }
    }
}
