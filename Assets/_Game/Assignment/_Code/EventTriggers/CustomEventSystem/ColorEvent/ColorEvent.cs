using Assignment._Code.EventTriggers.CustomEventSystem.BaseEvent;
using UnityEngine;

namespace Assignment._Code.EventTriggers.CustomEventSystem.ColorEvent
{
    [CreateAssetMenu(menuName = "CustomScriptables/Events/ColorEvent", fileName = "NewColorEvent")]
    public class ColorEvent : BaseGameEvent<Color>
    {
    }
}