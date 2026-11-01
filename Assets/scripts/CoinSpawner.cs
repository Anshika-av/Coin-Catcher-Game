
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public float spawnInterval = 2f;
    public float xLimit = 4f;
    public float spawnY = 5f;

    void Start()
    {
        InvokeRepeating("SpawnCoin", 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        float randomX = Random.Range(-xLimit, xLimit);

        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
