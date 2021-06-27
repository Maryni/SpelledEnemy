using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region public variables

    public List<EnemyConstrucor> listEnemies = new List<EnemyConstrucor>();

    #endregion public variables

    #region private variables



    #endregion private variables

    public void SetEnemy()
    {
        listEnemies.Add(new EnemyConstrucor());
    }

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
