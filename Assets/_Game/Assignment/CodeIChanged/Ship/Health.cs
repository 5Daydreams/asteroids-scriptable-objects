using System;
using Assignment._Code.EventTriggers.CustomEventSystem.VoidEvent;
using Assignment._Code.ScriptableSimpleValues.TrackableValue;
using UnityEngine;

namespace Assignment.CodeIChanged
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private VoidEvent _playerDead;
        [SerializeField] private TrackableInt _currentPlayerHealthReference;
        [SerializeField] private int _maxHealth;
        private int _currentHealth;

        private const int MIN_HEALTH = 0;

        private void OnEnable()
        {
            _currentPlayerHealthReference.CallbackOnValueChanged.AddListener(OnHealthChanged);
            _currentPlayerHealthReference.Value = _maxHealth;
        }

        private void OnDisable()
        {
            _currentPlayerHealthReference.CallbackOnValueChanged.RemoveListener(OnHealthChanged);
        }

        private void OnHealthChanged(int newHealthValue)
        {
            _currentPlayerHealthReference.Value = Mathf.Clamp(newHealthValue, MIN_HEALTH, _maxHealth);
            _currentHealth = _currentPlayerHealthReference.Value;
            
            Debug.Log("Current Health:" + _currentHealth );

            if (_currentHealth == MIN_HEALTH)
            {
                _playerDead.Raise();
            }
        }
    }
}