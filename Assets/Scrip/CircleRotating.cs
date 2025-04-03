using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public bool reverseRotation = false; 

    void Update()
    {
        float direction = reverseRotation ? -1 : 1;
        transform.Rotate(0, 0, rotationSpeed * direction * Time.deltaTime);
    }
}