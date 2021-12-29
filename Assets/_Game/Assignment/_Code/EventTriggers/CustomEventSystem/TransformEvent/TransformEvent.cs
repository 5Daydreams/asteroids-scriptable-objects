using Assignment._Code.EventTriggers.CustomEventSystem.BaseEvent;
using UnityEngine;

namespace Assignment._Code.EventTriggers.CustomEventSystem.TransformEvent
{
    [CreateAssetMenu(menuName = "CustomScriptables/Events/TransformEvent", fileName = "NewTransformEvent")]
    public class TransformEvent : BaseGameEvent<Transform>
    {
    }
}