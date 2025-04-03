using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject egg;
    public float minDropTime = 2.0f; 
    public float maxDropTime = 5.0f; 
    private bool isDroppingEgg = false;

    private void Start()
    {
        StartDroppingEgg();
    }

    private void StartDroppingEgg()
    {
        float dropTime = Random.Range(minDropTime, maxDropTime);
        Invoke(nameof(DropEgg), dropTime);
    }

    private void DropEgg()
    {
        if (!isDroppingEgg)
        {
            isDroppingEgg = true;

            Vector2 spawnPosition = new Vector2(
                transform.position.x + Random.Range(-0.5f, 0.5f), 
                transform.position.y
            );

            Instantiate(egg, spawnPosition, Quaternion.identity);
            isDroppingEgg = false;
            StartDroppingEgg();
        }
    }
}
