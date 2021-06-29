using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    #region private variables

    [SerializeField] private new ParticleSystem particleSystem;
    [SerializeField] private Enemy enemyConstrucorStats;
    [SerializeField] private Enemies enemies;

    #endregion private variables

    #region propertys

    public Enemy Enemy => enemyConstrucorStats;

    #endregion propertys

    #region private void

    private void Start()
    {
        enemies = GameObject.Find("GameManager").GetComponent<Enemies>();
        enemies.AddRandomEnemy();
        enemyConstrucorStats = enemies.GetEnemyAtLastIndex();
        enemyConstrucorStats.Spell.SetParticalSystem(particleSystem);
        enemyConstrucorStats.Spell.Uncast();
        
    }

    #endregion private void

}
