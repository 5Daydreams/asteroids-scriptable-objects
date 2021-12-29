using UnityEngine;

namespace Assignment._Code.ScriptableSimpleValues.SimpleValues
{
    [CreateAssetMenu(fileName = "FloatValue",menuName = "CustomScriptables/SimpleValue/Float")]
    public class FloatValue : SimpleValue<float>
    {
        public void AddToValue(float increment)
        {
            Value += increment;
        }
    }
}
