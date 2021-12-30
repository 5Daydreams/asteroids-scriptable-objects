using UnityEngine;

namespace Assignment._Code.ScriptableSimpleValues.TrackableValue
{
    [CreateAssetMenu(fileName = "IntTrackableValue", menuName = "CustomScriptables/TrackableValue/Int")]
    public class TrackableInt : Trackable<int>
    {
        public override int Value
        {
            get => _value;
            set
            {
                if (value == _value)
                {
                    return;
                }

                _value = value;
                CallbackOnValueChanged.Invoke(_value);
            }
        }

        public void AddToValue(int addingValue)
        {
            Value = _value + addingValue;
        }
    }
}