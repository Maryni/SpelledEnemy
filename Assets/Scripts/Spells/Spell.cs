using Assets.Scripts.Interface;
using UnityEngine;

public class Spell : ISpell
{
    #region private variables

    private string nameSpell;
    private float castTime;
    private float range;
    private int power;
    private ParticleSystem particleSystemSpell;

    #endregion private variables

    #region arrays

    private string[] nameSpells = { "Fire", "Water", "Wind", "Earth", "Divine", "Dark", "Nature", "Poison" };

    #endregion arrays

    #region properties

    public string NameSpell => nameSpell;
    public float CastTime => castTime;
    public float Range => range;
    public int Power => power;
    public ParticleSystem ParticleSystemSpell => particleSystemSpell;

    #endregion properties

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

    public void PauseCast()
    {
        particleSystemSpell.Pause();
    }

    public void StopCast()
    {
        particleSystemSpell.Stop();
    }

    public void SetParticalSystem(ParticleSystem particleSystemSpell)
    {
        this.particleSystemSpell = particleSystemSpell;
    }

    public void Init()
    {
        SetSpell();
    }

    public void Move(Transform target, Transform me)
    {
        var temp = particleSystemSpell.gameObject;
        var destination = target.position - me.position;
        destination = Vector3.Normalize(destination);
        temp.transform.position = new Vector3(temp.transform.position.x + destination.x * .5f,
                                                    temp.transform.position.y,
                                                    temp.transform.position.z + destination.z * .5f);
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

}
