using UnityEngine;

namespace Assignment._Code.ScriptableSimpleValues.SimpleValues
{
    public abstract class SimpleValue<T> : ScriptableObject
    {
        public T Value;

        public void SetValue(T overwrite)
        {
            Value = overwrite;
        }
    }
}