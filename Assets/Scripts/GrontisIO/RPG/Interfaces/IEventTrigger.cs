namespace GrontisIO.RPG.Interfaces
{
    public interface IEventTrigger <in T> where T : IDataTransferObject
    {
        void Trigger(T data);
    }
}
