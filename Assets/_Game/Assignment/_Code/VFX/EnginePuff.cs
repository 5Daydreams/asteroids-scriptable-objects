using System;
using UnityEngine;

namespace Assignment._Code.VFX
{
    public class EnginePuff : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _engineParticles;
        [SerializeField] private float _puffDropInterval = 0.1f;
        [SerializeField] private float _puffThrusterOffset = 0.1f;
        [SerializeField] private float _puffLateralOffset = 0.1f;
        private float _currentTimer;

        private void Update()
        {
            _currentTimer -= Time.deltaTime;

            if (_currentTimer < 0)
            {
                Vector3 dropPosition = this.transform.position - this.transform.up * _puffThrusterOffset;
                Vector3 lateraloffset = this.transform.right * _puffLateralOffset;
                Instantiate(_engineParticles, dropPosition + lateraloffset, this.transform.rotation, null);
                Instantiate(_engineParticles, dropPosition - lateraloffset, this.transform.rotation, null);
                _currentTimer = _puffDropInterval;
            }
        }
    }
}