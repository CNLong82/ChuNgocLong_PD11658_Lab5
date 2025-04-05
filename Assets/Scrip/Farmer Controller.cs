using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FarmerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image healthBar; 
    public float maxHealth = 1f;
    public float currentHealth = 0.5f; 
    public float healAmount = 0.1f;
    public TMP_Text Score;
    public float countScore = 0;
    private Rigidbody2D rb;
    private Animator animator;
    public float speed = 10f;
    public GameObject PanelWin;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = rb.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        animator = rb.GetComponent<Animator>();
        UpdateHealthUI();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveX * speed, rb.linearVelocity.y);
        rb.linearVelocity = movement;

        if (Mathf.Abs(moveX) > 0.1f)
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }

        if (moveX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("egg"))
        {
            countScore++;
            Score.text = "Score: " + countScore;

            if (currentHealth < maxHealth)
            {
                currentHealth += healAmount;
                if (currentHealth > maxHealth) currentHealth = maxHealth;
                UpdateHealthUI();
            }

            var name = other.attachedRigidbody.name;
            Destroy(GameObject.Find(name));

            if (countScore == 10)
            {
                {
                    PanelWin.SetActive(true);
                }
            }
        }
    }

    void UpdateHealthUI()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }

    public void RestartGame()
    {
        PanelWin.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
