using UnityEngine;

namespace Assignment.CodeIChanged
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Engine : MonoBehaviour
    {
        [SerializeField] private float _throttlePowerSimple;
        [SerializeField] private float _rotationPowerSimple;
        [SerializeField] private float _maxSpeed;

        private Rigidbody2D _rigidbody;

        // I decided to use my own input system to call these methods
        // private void FixedUpdate()
        // {
        //     if (Input.GetKey(KeyCode.UpArrow))
        //     {
        //         Throttle();
        //     }
        //
        //     if (Input.GetKey(KeyCode.LeftArrow))
        //     {
        //         SteerLeft();
        //     } 
        //     else if (Input.GetKey(KeyCode.RightArrow))
        //     {
        //         SteerRight();
        //     }
        // }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    
        public void Throttle()
        {
            _rigidbody.AddForce(transform.up * _throttlePowerSimple, ForceMode2D.Force);
            Vector3.ClampMagnitude(_rigidbody.velocity, _maxSpeed);
        }

        public void SteerLeft()
        {
            _rigidbody.AddTorque(_rotationPowerSimple, ForceMode2D.Force);
        }

        public void SteerRight()
        {
            _rigidbody.AddTorque(-_rotationPowerSimple, ForceMode2D.Force);
        }
    }
}
