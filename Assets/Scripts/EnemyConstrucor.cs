using Assets.Scripts.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConstrucor : MonoBehaviour, ISpell, IEnemy
{
    #region private variables

    private string nameSpell;
    private float castTime;
    private float range;
    private int power;
    private string name;
    [SerializeField] private ParticleSystem particleSystem;

    #endregion private variables

    #region propertys

    public string NameSpell => nameSpell;
    public float CastTime => castTime;
    public float Range => range;
    public int Power => power;
    public string Name => name;

    #endregion propertys

    #region arrays

    private string[] nameSpells = {"Fire", "Water", "Wind", "Earth", "Divine", "Dark", "Nature", "Elements" };

    #endregion arrays

    #region Conctructor

    public EnemyConstrucor()
    {
        GetNameSpell();
        GetSpell();
    }

    #endregion Conctructor

    #region public void

    public void Cast()
    {
        particleSystem.Play();
    }

    public void GetNameSpell()
    {
        nameSpell = nameSpells[Random.Range(0,8)] + Random.Range(1,5);
    }

    #endregion public void

    #region private void

    private void GetSpell()
    {
        nameSpell = nameSpells[Random.Range(0,8)];
        castTime = Random.Range(0.1f,3f);
        range = Random.Range(1, 21);
        power = Random.Range(1, 101);
    }

    #endregion private void


}
