namespace GrontisIO.Engine.RPG.Characters.Abilities
{
    public interface IAbility
    {
        string Name { get; set; }
        float Cost { get; set; }
        void Use();
    }
}
