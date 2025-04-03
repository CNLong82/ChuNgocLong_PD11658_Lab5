using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float novaX = Input.GetAxis("Horizontal");
        float novaY = Input.GetAxis("Vertical");
        Vector3 novaevent = new Vector3(novaX, novaY, 5f);
        transform.position += novaevent * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Resparm")) 
        {
            Destroy(gameObject);
        }
    }
}
