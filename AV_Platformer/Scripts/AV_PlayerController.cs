using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AV_PlayerController : MonoBehaviour
{
    //Instantiated fields like movement and jump force to Player object
    private Rigidbody2D rb2D;
    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    AV_GameManager av_gameManager;
    [SerializeField] GameObject gameManager;

    //Field to be used with the FallDetector object
    public GameObject fallDetector;

    // Start is called before the first frame update
    void Start()
    {
        //rb2D references the Rigidbody2D component of the Player object
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        //assigning values to previous fiedls upon the game starting
        moveSpeed = 3f;
        jumpForce = 60f;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);
    }
    //Fixed Update is used with physics. Instead of updating once per frame, it can update multiple times per frame if needed
    private void FixedUpdate()
    {
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if(!isJumping && moveVertical > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
    }

    //Checks if there is collision between player and tagged object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks to see if there is collision to determine if player is in a jumping state
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
        //Checks if collision between player object and FallDetector or Enemy object occurs
        //If collision occurs, it will load the Game Over scene
        else if (collision.gameObject.tag == "FallDetector" || collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("AV_CJGameOver");
        }
    }
    //Checks if collision stops to check if player is in jumping state
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Enemy")
        {
            isJumping = true;
        }
    }
}
