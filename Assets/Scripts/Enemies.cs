using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    #region public variables

    public EnemyConstrucor EnemyConstrucor => enemyConstrucor;

    #endregion public variables

    #region private variables

    [SerializeField] private List<EnemyConstrucor> listEnemies = new List<EnemyConstrucor>();
    [SerializeField] private List<EnemyStats> listEnemyStats = new List<EnemyStats>();
    private EnemyConstrucor enemyConstrucor;

    #endregion private variables


    #region public void

    public void AddRandomEnemy()
    {
        enemyConstrucor = new EnemyConstrucor();
        AddToListEnemies();
    }
    public void AddToListEnemyStats(GameObject box)
    {
        var temp = box.GetComponent<EnemyStats>();
        listEnemyStats.Add(temp);
    }

    #endregion public void

    #region private void

    private void AddToListEnemies()
    {
        listEnemies.Add(enemyConstrucor);
    }

    #endregion private void

    #region GetEnemy

    public EnemyConstrucor GetEnemy(int index)
    {
        return listEnemies[index];
    }
    public EnemyConstrucor GetEnemyLastIndex()
    {
        return listEnemies[listEnemies.Count];
    }
    public EnemyConstrucor GetEnemyFirstIndex()
    {
        return listEnemies[0];
    }
    public EnemyConstrucor GetEnemy(string name)
    {
        for (int i = 0; i < listEnemies.Count; i++)
        {
            if(name.Equals(listEnemies[i].Name))
            {
                return listEnemies[i];
            }
        }
        throw new System.Exception("Don't have this name into listEnemies");
    }

    #endregion GetEnemy
}
