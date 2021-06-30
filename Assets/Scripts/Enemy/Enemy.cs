using Assets.Scripts.Interface;
using UnityEngine;

public class Enemy : IEnemy
{
    #region private variables

    private string name;
    private ISpell spell;
    private GameObject targetGameObject;
    private GameObject myGameObject;

    #endregion private variables

    #region propertys

    public ISpell Spell => spell;
    public string Name => name;
    public GameObject Target => targetGameObject;
    public GameObject MyGameObject => myGameObject;

    #endregion propertys

    #region Conctructor

    public Enemy(string nameConstructor)
    {
        name = nameConstructor;
        spell = new Spell();

    }

    #endregion Conctructor

    #region public void

    public void WhoIam()
    {
        Debug.Log("I am [" + name + "] my name is [" + Name+"]");
        Debug.Log("My spellName is ["+spell.NameSpell+"]");
    }

    public void SetSpell(ISpell spell)
    {
        this.spell = spell;
    }

    public void SetEnemyTarget(GameObject target)
    {
        targetGameObject = target;
    }

    public void SetMyGameObject(GameObject me)
    {
        myGameObject = me;
    }

    public void Rotate()
    {
        if(targetGameObject!=null)
        {
            myGameObject.transform.LookAt(targetGameObject.transform);
        }
        else
        {
            throw new System.Exception("Don't have a target");
        }
    }

    public void Cast()
    {
        Spell.Move(targetGameObject.transform, myGameObject.transform);          
    }

    #endregion public void

    #region private void


    #endregion private void

}
