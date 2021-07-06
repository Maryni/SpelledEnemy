using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    #region private variables

    [SerializeField] private new ParticleSystem particleSystem;
    [SerializeField] private Enemy enemyConstrucorStats;
    [SerializeField] private Enemies enemies;
    [SerializeField] private GameObject me;

    [SerializeField] private float timer=5f;
    [SerializeField] private Enemy tempEnemy;
    private int count;

    #endregion private variables

    #region properties

    public Enemy Enemy => enemyConstrucorStats;

    #endregion properties

    #region private void

    private void Start()
    {
        enemies = GameObject.Find("GameManager").GetComponent<Enemies>();
        enemies.AddRandomEnemy();
        enemies.AddToListEnemyStats(me);
        enemyConstrucorStats = enemies.GetEnemyAtLastIndex();
        enemyConstrucorStats.Spell.SetParticalSystem(particleSystem);
        enemyConstrucorStats.Spell.Cast();
        enemyConstrucorStats.SetEnemyTarget(enemies.GetRandomEnemy());
        Enemy.Rotate();
        
    }

    private void FixedUpdate()
    {
        if (timer > 0f)
        {
            enemyConstrucorStats.Cast();
            timer -= 0.1f;
        }
        if (timer < 0f)
        {
            count = enemies.GetEnemiesCount();
            if(count>0)
            {
                for (int i = 0; i < count; i++)
                {
                    tempEnemy = enemies.GetEnemyByIndex(i);
                    enemyConstrucorStats = tempEnemy;
                    enemyConstrucorStats.Spell.StopCast();
                }
            }           
        }
        
    }

    #endregion private void
}
