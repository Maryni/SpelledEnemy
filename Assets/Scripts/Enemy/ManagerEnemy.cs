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

    private RaycastHit raycastHit;

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
        //Debug.DrawRay(pointToSpawn, Vector3.up *radius, Color.green);

        if (Physics.SphereCast(pointToSpawn, radius, Vector3.forward, out raycastHit))
        {
            print(raycastHit.collider.gameObject.name);
            if (raycastHit.collider.gameObject.name == "Plane")
            {
                return true;
            }
            if (raycastHit.collider.gameObject.name == "Box(Clone)")
            {
                return false;
            }
        }
        if (raycastHit.collider == null )
        {
            return true;
        }

        return false;       
    }

    private void SetChindToPlaneFromSpawnPoint(int index)
    {
        enemies[index] = pointToSpawnTransform.transform.GetChild(0).gameObject;
        enemies[index].transform.parent = plane.transform;
        enemies[index].transform.localPosition = pointToSpawnTransform.localPosition;
    }

    #endregion public void

}
