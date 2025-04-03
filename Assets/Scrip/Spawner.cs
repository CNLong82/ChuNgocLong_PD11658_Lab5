using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject player;
    private int count = 0;

    private void Update()
    {
        count++;
        if (count >= 300)
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            Vector3 direction = (player.transform.position - spawnedObject.transform.position).normalized;

            spawnedObject.GetComponent<Rigidbody2D>().linearVelocity = direction * 2f;
            Destroy(spawnedObject, 5f);
            count = 0;
        }
    }
}
