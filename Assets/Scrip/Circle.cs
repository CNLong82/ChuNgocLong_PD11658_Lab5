using UnityEngine;

public class Circle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityX = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
