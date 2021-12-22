using UnityEngine;

namespace Assignment.ScriptableSimpleValues.SimpleValues
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