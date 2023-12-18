using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float Jump;
    public float Crouch;
    public bool isJumping = false;
    public bool isCrouching = false;
    public GameObject RestartGame;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.AddForce(Vector2.up * Jump);
            isJumping = true;
            animator.SetBool("isJumping", true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector2.down * Jump);
            isJumping = false;
            animator.SetBool("isCrouching", true);
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            animator.SetBool("isJumping", false);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            animator.SetBool("Dead", true);
            Time.timeScale = 0;
            RestartGame.SetActive(true);
        }
        if (collision.gameObject.tag == "Ground")
        {
            isCrouching = false;
            animator.SetBool("isCrouching", false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}
