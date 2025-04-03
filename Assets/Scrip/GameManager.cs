using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject gameObjectA;
    public GameObject gameObjectB;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObjectA != null && gameObjectB != null) 
        {
            Vector3 directionToB = gameObjectA.transform.position - gameObjectB.transform.position;
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, directionToB);
            gameObjectA.transform.rotation = rotation;
        }
    }
}
