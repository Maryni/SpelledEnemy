using UnityEngine;

public class ManagerEnemy : MonoBehaviour
{
    #region private variables

    [SerializeField] private GameObject box;
    [SerializeField] private GameObject plane;
    [SerializeField] private GameObject[] enemies;

    [SerializeField] private Transform pointToSpawnTransform;
    [SerializeField] private Vector3 pointToSpawn;
    [SerializeField] private float radius;
    [SerializeField] private int countSpawn;

    [SerializeField] private EnemyStats currentEnemy;

    #endregion private variables

    private void Start()
    {
        InitalizeBoxes(countSpawn);
    }

    #region public void

    public void InitalizeBoxes(int count)
    {
        enemies = new GameObject[count];

            for (int i = 0; i < count; i++)
            {
                SetRandomPoint();
                if(IsCanPlaceNearbyPoint())
                {
                    var item = Instantiate(box.transform, pointToSpawnTransform.position, Quaternion.identity);
                    item.transform.parent = pointToSpawnTransform;
                    SetChindToPlaneFromSpawnPoint(i);
                }
                else
                {
                    i--;
                }    
            }
    }

    #endregion public void

    #region private void 

    private void SetRandomPoint()
    {
        pointToSpawn.x = Random.Range(-4f, 4f);
        pointToSpawn.y = 0.5f;
        pointToSpawn.z = Random.Range(-4f, 4f);
        pointToSpawnTransform.position = pointToSpawn; //just for understand on scene where is pointToSpawn will be
    }
    private bool IsCanPlaceNearbyPoint()
    {
        var arraySphereAll = Physics.OverlapSphere(pointToSpawn, radius);
        foreach(var item in arraySphereAll)
        {
            var stats = item.GetComponent<EnemyStats>();
            if (stats != null)
            {
                return false;
            }
        }
        return true;
    }

    private void SetChindToPlaneFromSpawnPoint(int index)
    {
        enemies[index] = pointToSpawnTransform.transform.GetChild(0).gameObject;
        enemies[index].transform.parent = plane.transform;
        enemies[index].transform.position = pointToSpawnTransform.localPosition;
    }

    #endregion public void

}
