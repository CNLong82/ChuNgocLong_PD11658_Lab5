using UnityEngine;

public class TringlaControll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject tringle;
    void Start()
    {
        tringle = GameObject.FindWithTag("Player");
        Transform haha = tringle.transform;
        haha.position = Vector2.zero;

        Rigidbody2D rb = haha.GetComponent<Rigidbody2D>();
        rb.mass = 10.0f;
        Destroy(tringle, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
