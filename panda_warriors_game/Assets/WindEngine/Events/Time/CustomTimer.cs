using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace WindEngine.Events
{
    [AddComponentMenu("WindEngine/Time/Custom Timer")]
    public class CustomTimer : MonoBehaviour
    {
        public UnityEvent OnTimerHasEnded;
        public UnityEvent OnEveryTimerTick;
        public float timerDuration;
        [HideInInspector]
        public float timerCounter;
        [HideInInspector]
        public bool isTimerWorking;

        public void OnTimerEnded()
        {
            OnTimerHasEnded.Invoke();
        }

        public void OnEveryTick()
        {
            OnEveryTimerTick.Invoke();
        }

        public void Update()
        {
            if (isTimerWorking) { ApplyTimer(); }
        }

        public void ApplyTimer()
        {
            if (!IsTimerEnded()) { timerCounter -= Time.deltaTime; }
        }

        public void BeginTimer()
        {
            timerCounter = timerDuration;
            isTimerWorking = true;
        }

        public void PauseTimer()
        {
            isTimerWorking = !isTimerWorking;
        }

        public void StopTimer()
        {
            isTimerWorking = false;
            timerCounter = 0;
        }

        public bool IsTimerEnded()
        {
            bool isEnded = (timerCounter <= 0) ? true : false;
            if (isEnded) { timerCounter = 0; isTimerWorking = false; } else { OnEveryTick(); }
            return isEnded;
        }
    }
}
