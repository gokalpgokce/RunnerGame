using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject ground;
    public Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(ground, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }
    }

}
