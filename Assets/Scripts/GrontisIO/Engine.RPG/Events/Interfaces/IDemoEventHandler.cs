using UnityEngine.EventSystems;

namespace GrontisIO.Engine.RPG.Events.Interfaces
{
    public interface IDemoEventHandler : IEventSystemHandler
    {
        void OnEvent(IDataTransferObject eventData);
    }
}
