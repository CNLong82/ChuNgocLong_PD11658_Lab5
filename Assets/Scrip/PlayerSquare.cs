using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.Jobs;

public class PlayerSquare : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject PanelWin;
    private Vector3 startPosition;
    public float coin = 0;
    public GameData gameData;
    private float startTime;
    public int deathCount = 0;
    public TextMeshProUGUI deathText;
    void Start()
    {
        startPosition = transform.position;
        startTime = Time.time;
        deathCount = PlayerPrefs.GetInt("DeathCount", 0);
        UpdateDeathUI();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0).normalized;
        transform.Translate(movement * 5f * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("circle"))
        {
            transform.position = startPosition;
            deathCount++;
            PlayerPrefs.SetInt("DeathCount", deathCount); 
            PlayerPrefs.Save();
            UpdateDeathUI(); 
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("circle"))
        {
            transform.position = startPosition;
            deathCount++;
            PlayerPrefs.SetInt("DeathCount", deathCount); 
            PlayerPrefs.Save();
            UpdateDeathUI();
        }

        if (other.gameObject.CompareTag("green"))
        {
            SceneManager.LoadScene("game 3 level 2");
        }

        if (other.gameObject.CompareTag("coin"))
        {
            coin++;
            var name = other.attachedRigidbody.name;
            Destroy(GameObject.Find(name));
            if (coin == 8)
            {
                SceneManager.LoadScene("game 3 level 3");
            }
        }

        if (other.CompareTag("checkpoint"))
        {
            startPosition = other.transform.position;
        }

        if (other.gameObject.CompareTag("green2"))
        {
           if(coin == 6)
           {
               SceneManager.LoadScene("game 3 level 4");
           }           
        }

        if (other.gameObject.CompareTag("box"))
        {
            PanelWin.SetActive(true);
            int finishTime = Mathf.FloorToInt(Time.time - startTime);

            if (gameData.bestTime == 0 || finishTime < gameData.bestTime)
            {
                gameData.bestTime = finishTime;
                Debug.Log("New Best Time: " + finishTime + " seconds");
            }
        }
    }
    public void RestartGame()
    {
        PanelWin.SetActive(false);
        PlayerPrefs.SetInt("DeathCount", 0); 
        PlayerPrefs.Save();
        SceneManager.LoadScene("game 3");
    }
    public void MainMenu()
    {
        PlayerPrefs.SetInt("DeathCount", 0);
        PlayerPrefs.Save();
        SceneManager.LoadScene("menu");
    }
    void UpdateDeathUI()
    {
        if (deathText != null)
        {
            deathText.text = "Deaths: " + deathCount;
        }
    }
}
