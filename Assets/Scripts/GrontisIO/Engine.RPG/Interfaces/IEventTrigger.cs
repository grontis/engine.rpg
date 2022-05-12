namespace GrontisIO.Engine.RPG.Interfaces
{
    public interface IEventTrigger <in T> where T : IDataTransferObject
    {
        void Trigger(T data);
    }
}
