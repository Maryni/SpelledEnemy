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
     void PauseCast();
     void StopCast();
     void SetParticalSystem(ParticleSystem particleSystemSpell);
     void Move(Transform target, Transform me);
    }         
}
