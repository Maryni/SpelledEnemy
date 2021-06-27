using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemy : MonoBehaviour
{
    private Enemy enemy;

    private void Start()
    {
        enemy.SetEnemy();
    }
}
