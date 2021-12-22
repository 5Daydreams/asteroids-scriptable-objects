using UnityEngine;

namespace Assignment.ScriptableSimpleValues.SingleScriptables
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
