using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("platform"))
        {
            Destroy(gameObject);
            GameObject Eggbroken = Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(Eggbroken, 0.5f);
        }
    }
}
