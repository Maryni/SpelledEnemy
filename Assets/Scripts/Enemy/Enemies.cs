using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    #region public variables

    public Enemy Enemy => enemy;

    #endregion public variables

    #region private variables

    [SerializeField] private List<Enemy> listEnemies = new List<Enemy>();
    [SerializeField] private List<EnemyStats> listEnemyStats = new List<EnemyStats>();
    private Enemy enemy;

    #endregion private variables

    #region public void

    public void AddRandomEnemy()
    {
        enemy = new Enemy("Bartolomeo");
        AddToListEnemies();
    }
    public void AddToListEnemyStats(GameObject box)
    {
        var temp = box.GetComponent<EnemyStats>();
        if(temp!= null)
        {
            listEnemyStats.Add(temp);
            Enemy.SetMyGameObject(box);
        }
    }

    public void SetTargetEnemy(GameObject gameObject)
    {
        Enemy.SetEnemyTarget(gameObject);
    }

    public GameObject GetRandomEnemy()
    {
        return listEnemies[Random.Range(0, listEnemies.Count)].MyGameObject;
    }

    #endregion public void

    #region private void

    private void AddToListEnemies()
    {
        listEnemies.Add(enemy);
    }

    #endregion private void

    #region GetEnemy

    public int GetEnemiesCount()
    {
        return listEnemies.Count;
    }

    public Enemy GetEnemyByIndex(int index)
    {
        return listEnemies[index];
    }
    public Enemy GetEnemyAtLastIndex()
    {
        return listEnemies[listEnemies.Count-1];
    }
    public Enemy GetEnemyAtFirstIndex()
    {
        return listEnemies[0];
    }
    public Enemy GetEnemy(string name)
    {
        for (int i = 0; i < listEnemies.Count; i++)
        {
            if(name.Equals(listEnemies[i].Name))
            {
                return listEnemies[i];
            }
        }
        throw new System.Exception($"Don't have this enemy with that name - {name} into listEnemies");
    }

    #endregion GetEnemy

}
