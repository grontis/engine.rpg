namespace GrontisIO.Engine.RPG.Events.Interfaces
{
    public interface IEventTrigger <in T> where T : IDataTransferObject
    {
        void Trigger(T data);
    }
}
