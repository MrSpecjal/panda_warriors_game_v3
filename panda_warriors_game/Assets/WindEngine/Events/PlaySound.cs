using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace WindEngine.Events
{
    [ExecuteInEditMode]
    [AddComponentMenu("WindEngine/Events/PlaySound")]
    [RequireComponent(typeof(AudioSource))]
    public class PlaySound : MonoBehaviour
    {   
        private AudioSource sound;
        [ExecuteInEditMode]
        private void Awake()
        {
            sound = GetComponent<AudioSource>();
        }

        public void Play()
        {
            sound.Play();
        }
    }
}
