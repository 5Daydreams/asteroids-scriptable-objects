using UnityEngine;

namespace Assignment._Code.ScriptableSimpleValues.SingleScriptables
{
    [CreateAssetMenu(menuName = "CustomScriptables/DebugMessager")]
    public class EventLog : ScriptableObject
    {
        public void ConsoleLog(string message)
        {
            Debug.Log(message);
        }
    }
}
