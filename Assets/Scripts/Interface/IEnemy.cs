namespace Assets.Scripts.Interface
{
    public interface IEnemy
    {
        string Name { get; }
        ISpell Spell { get; }

        void Rotate();
        void Cast();

    }
}
