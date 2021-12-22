﻿using UnityEngine;

namespace Assignment.ScriptableSimpleValues.TrackableValue
{
    [CreateAssetMenu(fileName = "FloatTrackableValue",menuName = "CustomScriptables/TrackableValue/Float")]
    public class TrackableFloat : Trackable<float>
    {
        public void AddToValue(float addingValue)
        {
            Value = _value + addingValue;
        }
    }
}