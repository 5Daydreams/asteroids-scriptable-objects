namespace Assignment._Code.EventTriggers.CustomEventSystem.BaseEvent
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}