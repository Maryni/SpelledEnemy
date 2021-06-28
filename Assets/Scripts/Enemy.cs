using Assets.Scripts.Interface;
using UnityEngine;

public class Enemy : IEnemy
{
    #region private variables

    private string name;
    private ISpell spell;

    #endregion private variables

    #region propertys

    public ISpell Spell => spell;
    public string Name => name;

    #endregion propertys

    #region Conctructor

    public Enemy(string nameConstructor)
    {
        name = nameConstructor;
        spell = new Spells();

    }

    #endregion Conctructor

    #region public void

    public void WhoIam()
    {
        Debug.Log("I am [" + name + "] my name is [" + Name+"]");
        Debug.Log("My spellName is ["+spell.NameSpell+"]");
    }
    public void GetSpell(ISpell spell)
    {
        this.spell = spell;
    }

    #endregion public void

    #region private void


    #endregion private void


}
