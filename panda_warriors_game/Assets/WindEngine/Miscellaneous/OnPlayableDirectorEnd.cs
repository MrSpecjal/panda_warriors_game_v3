using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

namespace WindEngine.Miscellaneous
{
    [RequireComponent(typeof(PlayableDirector))]
    public class OnPlayableDirectorEnd : MonoBehaviour
    {
        PlayableDirector playableDirector;
        public UnityEvent OnTimelineEnd;
        private void Awake()
        {
            playableDirector = GetComponent<PlayableDirector>();
        }

        private void Update()
        {
            if(playableDirector.state != PlayState.Playing)
            {
                OnTimelineEnd.Invoke();
            }
        }
    }
}
