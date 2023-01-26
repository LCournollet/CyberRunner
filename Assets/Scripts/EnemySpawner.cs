using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesCount = 3;

    public float margin = .25f;

    private void Start()
    {
        // A
        Vector3 enemiesSpawnerPosition = transform.position;
        Quaternion noRotation = Quaternion.identity;

        Camera camera = Camera.main;
        float verticalHalfSize = camera.orthographicSize;
        float horizontalHalfSize = verticalHalfSize * camera.aspect;

        float x = (2 * horizontalHalfSize - 2 * margin) / (enemiesCount - 1);
        Vector3 distanceBetweenAnimals = new(x, 0, 0);
        Vector3 playerPosition = Vector3.zero;

        for (int i = 0; i < enemiesCount; i++)
        {
            float offset = i - (float)(enemiesCount - 1) / 2;
            Vector3 newPosition = enemiesSpawnerPosition + offset * distanceBetweenAnimals;
            Instantiate(enemyPrefab, newPosition, noRotation);

            if (i + 1 == enemiesCount / 2)
            {
                playerPosition = newPosition;
            }
        }
    }
}
