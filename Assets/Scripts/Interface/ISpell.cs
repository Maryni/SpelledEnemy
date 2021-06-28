using UnityEngine;

namespace Assets.Scripts.Interface
{
    public interface ISpell
    {
     string NameSpell { get; }
     float CastTime { get; }
     float Range { get; }
     int Power { get; }
     void Cast();
     void Uncast();
     void GetParticalSystem(ParticleSystem particleSystemSpell);
    }         
}
