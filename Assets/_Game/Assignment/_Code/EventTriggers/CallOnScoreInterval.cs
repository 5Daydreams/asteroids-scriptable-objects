using Assignment.ScriptableSimpleValues.TrackableValue;
using UnityEngine;
using UnityEngine.Events;

namespace Assignment.SimpleScripts.BasicConditionTriggers
{
    public class CallOnScoreInterval : MonoBehaviour
    {
        [SerializeField] private TrackableInt _playerScore;
        [SerializeField] private int _interval;
        [SerializeField] private UnityEvent _callback;
        private int _acumulatedSpeedBoosts = 0;

        private void OnEnable()
        {
            _playerScore.CallbackOnValueChanged.AddListener(TryScoreCallback);
        
            void TryScoreCallback(int value)
            {
                if (value == 0)
                {
                    return;
                }

                while (value / _interval > _acumulatedSpeedBoosts)
                {
                    _acumulatedSpeedBoosts++;
                    _callback.Invoke();
                }
            }
        }
    }
}