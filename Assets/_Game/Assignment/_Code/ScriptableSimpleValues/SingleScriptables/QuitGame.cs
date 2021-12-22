using UnityEngine;

namespace Assignment.ScriptableSimpleValues.SingleScriptables
{
    [CreateAssetMenu(fileName = "QuitGame", menuName = "CustomScriptables/QuitGame")]
    public class QuitGame : ScriptableObject
    {
        public void Exit()
        {
            Application.Quit();
        }
    }
}