using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefabCicle;
    public GameObject prefabTringle;
    public GameObject prefabSquare;
    void Start()
    {
        GameObject spare = GameObject.FindWithTag("sqare");
        if (spare != null)
        {
            prefabSquare.transform.position = new Vector2(1, 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            Vector2 pos = new Vector2(1f, 1.0f);
            GameObject a = Instantiate(prefabCicle, pos, Quaternion.identity);
            Destroy(a,1);
        }
    }
}
