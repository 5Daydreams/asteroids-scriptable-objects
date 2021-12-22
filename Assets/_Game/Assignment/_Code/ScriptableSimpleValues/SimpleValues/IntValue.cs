using UnityEngine;

namespace Assignment.ScriptableSimpleValues.SimpleValues
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