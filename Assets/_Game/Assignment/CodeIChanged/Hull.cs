using System;
using Assignment.ScriptableSimpleValues.TrackableValue;
using ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        [SerializeField] private TrackableInt _currentHealth;
        [SerializeField] private int _maxHealth;

        private void OnEnable()
        {
            _currentHealth.Value = _maxHealth;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                _currentHealth.Value--;
            }
        }
    }
}
