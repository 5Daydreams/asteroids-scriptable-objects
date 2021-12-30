using UnityEngine;

namespace Assignment._Code.ScriptableSimpleValues.TrackableValue
{
    [CreateAssetMenu(fileName = "FloatTrackableValue",menuName = "CustomScriptables/TrackableValue/Float")]
    public class TrackableFloat : Trackable<float>
    {
        public override float Value
        {
            get => _value;
            set
            {
                if (Mathf.Approximately(value,_value))
                {
                    return;
                }

                _value = value;
                CallbackOnValueChanged.Invoke(_value);
            }
        }
        public void AddToValue(float addingValue)
        {
            Value = _value + addingValue;
        }
    }
}