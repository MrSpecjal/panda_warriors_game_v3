using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace WindEngine.Events
{
    [AddComponentMenu("WindEngine/Events/TriggerEvents")]
    public class TriggerEvents : MonoBehaviour
    {
        public string triggerActivationTag;
        public UnityEvent TriggerEnter;
        public UnityEvent TriggerExit;
        public UnityEvent TriggerStay;
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == triggerActivationTag)
            {
                TriggerEnter.Invoke();
            }
        }
        void OnTriggerExit(Collider other)
        {
            if (other.tag == triggerActivationTag)
            {
                TriggerExit.Invoke();
            }
        }
        void OnTriggerStay(Collider other)
        {
            if (other.tag == triggerActivationTag)
            {
                TriggerStay.Invoke();
            }
        }
    }
}