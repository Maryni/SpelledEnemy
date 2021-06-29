namespace Assets.Scripts.Interface
{
    public interface IEnemy
    {
        string Name { get; }
        ISpell Spell { get; }

        //Rotate() - вбырать рандомного чувака, и в него кастить спелл
        //Cast() - форвардом двигаешь спелл с переодичностью в N секунд
    }
}