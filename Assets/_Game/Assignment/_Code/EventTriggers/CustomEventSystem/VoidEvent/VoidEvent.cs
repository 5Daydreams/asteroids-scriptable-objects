using Assignment._Code.EventTriggers.CustomEventSystem.BaseEvent;
using UnityEngine;

namespace Assignment._Code.EventTriggers.CustomEventSystem.VoidEvent
{
    [CreateAssetMenu(menuName = "CustomScriptables/Events/VoidEvent", fileName = "NewVoidEvent")]
    public class VoidEvent : BaseGameEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}