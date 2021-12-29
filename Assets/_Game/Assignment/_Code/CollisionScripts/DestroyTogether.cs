using UnityEngine;

namespace Assignment._Code.CollisionScripts
{
    public class DestroyTogether : MonoBehaviour
    {
        [SerializeField] private GameObject _target;

        private void OnDestroy()
        {
            Destroy(_target);
        }
    }
}
