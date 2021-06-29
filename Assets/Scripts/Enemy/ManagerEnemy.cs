using System.Linq;
using UnityEngine;

public class ManagerEnemy : MonoBehaviour
{
    #region private variables

    [SerializeField] private EnemyStats stats;
    [SerializeField] private GameObject box;
    [SerializeField] private Transform enemiesParent;
    [SerializeField] private Vector3 pointToSpawn;
    [SerializeField] private float radius;
    [SerializeField] private int countSpawn;

    #endregion private variables

    private RaycastHit[] raycastHit;

    private void Start()
    {
        InitalizeBoxes(countSpawn);
    }

    #region public void

    public void InitalizeBoxes(int count)
    {
        for (int i = 0; i < count; i++)
        {
            SetRandomPoint();
            if (IsCanPlaceNearbyPoint())
            {
                var item = Instantiate(box, pointToSpawn, Quaternion.identity);
                item.transform.parent = enemiesParent;
                continue;
            }

            i--;
        }
    }

    #endregion public void

    #region private void

    private void SetRandomPoint()
    {
        pointToSpawn = new Vector3(Random.Range(-4f, 4f), 0.5f, Random.Range(-4f, 4f));
        //just for understand on scene where is pointToSpawn will be
    }

    private bool IsCanPlaceNearbyPoint()
    {
        var arraySphereAll = Physics.OverlapSphere(pointToSpawn, radius);
        return false; //arraySphereAll.Any(x => x.GetComponent<EnemyStats>());
    }

    #endregion private void
}