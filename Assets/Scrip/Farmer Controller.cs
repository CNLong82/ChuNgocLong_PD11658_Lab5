using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class FarmerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

    public void RestartGame()
    {
        PanelWin.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
