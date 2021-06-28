
using UnityEngine;

public class ManagerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject box;
    [SerializeField] private GameObject plane;
    [SerializeField] private GameObject[] enemies;

    [SerializeField] private EnemyStats currentEnemy;

    private void Start()
    {
        InitalizeBoxes(4);
    }

    public void InitalizeBoxes(int count)
    {
        enemies = new GameObject[count];
        for (int i = 0; i < count; i++)
        {
            Instantiate(box.transform, plane.transform, true);
            enemies[i] = plane.transform.GetChild(i).gameObject;

            
        }

    }
}
