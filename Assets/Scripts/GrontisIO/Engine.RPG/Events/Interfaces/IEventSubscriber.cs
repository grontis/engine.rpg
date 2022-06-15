namespace GrontisIO.Engine.RPG.Events.Interfaces
{
    public interface IEventSubscriber
    {
        void SubscribeEvents();
        void UnsubscribeEvents();
    }
}
