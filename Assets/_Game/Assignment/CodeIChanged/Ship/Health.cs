using Assignment._Code.EventTriggers.CustomEventSystem.VoidEvent;
using UnityEngine;

namespace Assignment.CodeIChanged
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private VoidEvent _playerDead;
        private int _health = 10;
        
        private const int MIN_HEALTH = 0;
        
        public void TakeDamage(int damage)
        { 
            Debug.Log("Took some damage");
            _health = Mathf.Max(MIN_HEALTH, _health - damage);

            if (_health == MIN_HEALTH)
            {
                _playerDead.Raise();
            }
        }
    }
}
