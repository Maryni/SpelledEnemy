using Assets.Scripts.Interface;
using UnityEngine;

public class Spell : MonoBehaviour, ISpell
{
    #region private variables

    private string nameSpell;
    private float castTime;
    private float range;
    private int power;
    private ParticleSystem particleSystemSpell;

    #endregion private variables

    #region arrays

    private string[] nameSpells = {"Fire", "Water", "Wind", "Earth", "Divine", "Dark", "Nature", "Poison"};

    #endregion arrays

    #region propertys

    public string NameSpell => nameSpell;
    public float CastTime => castTime;
    public float Range => range;
    public int Power => power;

    #endregion propertys

    #region Constructors

    public Spell()
    {
        SetSpell();
    }

    public Spell(float castTimeSpell, float rangeSpell, int powerSpell)
    {
        castTime = castTimeSpell;
        range = rangeSpell;
        power = powerSpell;
    }

    #endregion Constructors

    #region public void

    public void Cast()
    {
        particleSystemSpell.Play();
    }

    public void Uncast()
    {
        particleSystemSpell.Pause();
    }

    public void GetParticalSystem(ParticleSystem particleSystemSpell)
    {
        this.particleSystemSpell = particleSystemSpell;
    }

    #endregion public void

    #region private void

    private void SetNameSpell()
    {
        nameSpell = "" + nameSpells[Random.Range(0, 8)] + Random.Range(1, 5);
    }

    private void SetSpell()
    {
        SetNameSpell();
        if (castTime == 0)
            castTime = Random.Range(0.1f, 3f);
        if (range == 0)
            range = Random.Range(1, 21);
        if (power == 0)
            power = Random.Range(1, 101);
    }

    #endregion private void

    public void Init()
    {
        SetSpell();
    }
}