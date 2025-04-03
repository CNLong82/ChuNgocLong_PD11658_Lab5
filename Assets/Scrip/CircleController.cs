using UnityEngine;

public class CircleController : MonoBehaviour
{
    private int direction;
    public float moveSpeed = 3f;
    public bool reverseDirection = false;

    void Update()
    {
 
        int finalDirection = reverseDirection ? -1 : 1;

        transform.Translate(new Vector3(0f, finalDirection * moveSpeed * Time.deltaTime, 0f));
        if (transform.position.y >= 3.5f || transform.position.y <= -3.5f)
        {
            reverseDirection = !reverseDirection; 
        }
    }
}