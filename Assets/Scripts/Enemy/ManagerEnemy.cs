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

    private RaycastHit[] raycastHit;

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
                    //print(i);
                    Instantiate(box.transform, pointToSpawnTransform, true);
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
        Debug.DrawRay(pointToSpawnTransform.position, Vector3.one *radius, Color.green);

        var arraySphereAll = Physics.SphereCastAll(pointToSpawn, radius, Vector3.zero);
        
        foreach( var item in arraySphereAll)
        {
            print(item.collider);
        }
        print("L = "+arraySphereAll.Length);
        return true;
    //    {
    //        if (raycastHit.transform.tag == "Plane")
    //        {
    //            print(raycastHit.collider);
    //            return true;
    //        }
    //        if (raycastHit.transform.tag == "Box")
    //        {
    //            print(raycastHit.collider);
    //            return false;
    //        }
    //    }

    //    if (raycastHit.collider == null )
    //    {
    //        print(raycastHit.collider);
    //        return true;
    //    }
    //    print(raycastHit.collider);
    //    return false;       
    }

    private void SetChindToPlaneFromSpawnPoint(int index)
    {
        enemies[index] = pointToSpawnTransform.transform.GetChild(0).gameObject;
        enemies[index].transform.parent = plane.transform;
        enemies[index].transform.position = pointToSpawnTransform.localPosition;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(pointToSpawn, radius);
    }

    #endregion public void

}
