using UnityEngine;

namespace Assignment._Code.Timer
{
    public class DestroyAfterSeconds : MonoBehaviour
    {
        [SerializeField] private float _lifetime;
        private float currentLifetime;
        void Start()
        {
            currentLifetime = _lifetime;
        }

        void Update()
        {
            currentLifetime -= Time.deltaTime;
        
            if (currentLifetime < 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
