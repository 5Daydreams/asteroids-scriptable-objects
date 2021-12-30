using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Assignment._Code.CollisionScripts
{
    [RequireComponent(typeof(Collider2D))]
    public class ColliderEnterCallback2D : MonoBehaviour
    {
        [Tooltip("Leave as empty list if no tag is required")] 
        [SerializeField] private List<string> _targetTags;
        [SerializeField] private bool _destroyOther;
        [SerializeField] private bool _destroySelf;
        [Space]
        [SerializeField] private UnityEvent _onTriggerEnterCallback;
        [SerializeField] private UnityEvent _onColliderEnterCallback;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.enabled)
            {
                return;
            }

            if (_targetTags.Count == 0)
            {
                ResolveTriggerCallbacks(other);
                return;
            }

            foreach (var collisionTag in _targetTags)
            {
                if (other.CompareTag(collisionTag))
                {
                    ResolveTriggerCallbacks(other);
                }
            }
        }

        private void ResolveTriggerCallbacks(Collider2D other)
        {
            _onTriggerEnterCallback?.Invoke();

            if (_destroyOther)
            {
                Destroy(other.gameObject);
            }

            if (_destroySelf)
            {
                Destroy(this.gameObject);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Collider2D otherCollider = other.collider;
            
            if (!otherCollider.enabled)
            {
                return;
            }
        
            if (_targetTags.Count == 0)
            {
                ResolveCollisionCallbacks(otherCollider);
                return;
            }
        
            foreach (var collisionTag in _targetTags)
            {
                if (otherCollider.CompareTag(collisionTag))
                {
                    ResolveCollisionCallbacks(otherCollider);
                }
            }
        }

        private void ResolveCollisionCallbacks(Collider2D other)
        {
            
        }
    }
}