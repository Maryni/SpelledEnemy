using System;
using Assets.Scripts.Interface;
using UnityEngine;

public class Enemy : IEnemy
{
    #region private variables

    private string name;
    private ISpell spell;

    #endregion private variables

    #region properties

    public ISpell Spell => spell;
    public string Name => name;

    #endregion properties

    #region Conctructor

    public Enemy(string nameConstructor)
    {
        name = nameConstructor;
        spell = new GameObject().AddComponent<Spell>();
        spell.Init();
    }

    #endregion Conctructor

    #region public void

    public void WhoIam() //лишнее убрать
    {
        Debug.Log("I am [" + name + "] my name is [" + Name + "]");
        Debug.Log("My spellName is [" + spell.NameSpell + "]");
    }

    public void GetSpell(ISpell spell) //поменять на сет
    {
        this.spell = spell;
    }

    #endregion public void

    #region private void

    #endregion private void
}