
using UnityEngine;

public class ManagerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject box;
    [SerializeField] private Transform plane;
    [SerializeField] private GameObject[] enemies;

    private Enemies enemy = new Enemies();

    private void Start()
    {
        //enemy.AddRandomEnemy();
        //enemy.EnemyConstrucor.Cast();
        InitalizeBoxes(4);
    }

    public void InitalizeBoxes(int count)
    {
        enemies = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            Instantiate(box.transform, plane, true);
            enemies[i] = plane.GetChild(i).gameObject;
            //enemies[i].AddRandomEnemy();
            //enemies[i].EnemyConstrucor.Cast();
        }

    }
}
