using Ship;
using UnityEngine;

namespace Assignment.CodeIChanged
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _laserPrefab;
        [Range(0.01f,1.0f)][SerializeField] private float _shootCooldown = 0.1f;
        private float _internalTimer;

        // I decided to use my own input system here as well
        private void Update()
        {
            //     if (Input.GetKeyDown(KeyCode.Space))
            //         Shoot();

            if (_internalTimer < _shootCooldown)
            {
                _internalTimer += Time.deltaTime;
            }
        }

        private void Shoot()
        {
            var trans = transform;
            Instantiate(_laserPrefab, trans.position, trans.rotation);
        }

        public void TryShoot()
        {
            if (_internalTimer < _shootCooldown)
            {
                return;
            }
            
            Shoot();
            _internalTimer = 0;
        }
    }
}