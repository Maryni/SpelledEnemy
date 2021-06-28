using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private Enemy enemyConstrucorStats;
    [SerializeField] private Enemies enemies;
    public Enemy Enemy => enemyConstrucorStats;

    private void Start()
    {
        enemies = GameObject.Find("GameManager").GetComponent<Enemies>();
        enemies.AddRandomEnemy();
        enemyConstrucorStats = enemies.GetEnemyAtLastIndex();
        enemyConstrucorStats.Spell.GetParticalSystem(particleSystem);
        enemyConstrucorStats.Spell.Uncast();
        
    }
}
