using UnityEngine;

namespace Assignment.ScriptableSimpleValues.TrackableValue
{
    [CreateAssetMenu(fileName = "IntTrackableValue",menuName = "CustomScriptables/TrackableValue/Int")]
    public class TrackableInt : Trackable<int>
    {
        public void AddToValue(int addingValue)
        {
            Value = _value + addingValue;
        }
    }
}