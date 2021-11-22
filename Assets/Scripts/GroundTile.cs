using UnityEngine;

public class GroundTile : MonoBehaviour
{
    private GroundSpawner _groundSpawner;
    public GameObject obstaclePrefab;
    void Start()
    {
        _groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        _groundSpawner.SpawnTile();
        Destroy(gameObject,2);
    }

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
