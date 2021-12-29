using UnityEngine;

namespace Assignment._Code.ScriptableSimpleValues.SimpleValues
{
    [CreateAssetMenu(fileName = "IntValue", menuName = "CustomScriptables/SimpleValue/Int")]
    public class IntValue : SimpleValue<int>
    {
        public void IncrementValue()
        {
            Value++;
        }
    }
}