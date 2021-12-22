using UnityEngine;

namespace Assignment.SimpleScripts
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
