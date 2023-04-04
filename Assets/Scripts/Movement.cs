using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Transform groundCheck;
    bool grounded = false;
    private Animator An;
    private BoxCollider2D Attack1Hitbox;
    private Rigidbody2D player;
    private float Speed = 6f;
    private float JumpSpeed = 12f;
    private float DownSpeed = 0.03f;
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
        An = GetComponent<Animator>();
    }
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetKey(KeyCode.A))
        {
            player.velocity = new Vector2(-Speed, player.velocity.y);
        }
        else if (player.velocity.x < 0)
        {
            player.velocity = new Vector2(player.velocity.x / ((10f * Time.deltaTime) + 1f), player.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.velocity = new Vector2(Speed, player.velocity.y);
        }
        else if (player.velocity.x > 0)
        {
            player.velocity = new Vector2(player.velocity.x / ((10f * Time.deltaTime) + 1f), player.velocity.y);
        }
        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.D)))
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }
        if (grounded == false && Input.GetKey(KeyCode.S))
        {
            player.velocity -= new Vector2(0, DownSpeed);
        }
        if ((Input.GetKeyDown(KeyCode.W))&&(grounded))
        {
            player.velocity = new Vector2(player.velocity.x, JumpSpeed);
            grounded = false;
        }
        if (player.velocity.x > 0.5 || player.velocity.y > 0.5 || player.velocity.x < -0.5 || player.velocity.y < -0.5)
        {
            An.SetBool("isRunning", true);
        }
        else An.SetBool("isRunning", false);
        if (player.velocity.x < -0.1)
        {
            transform.localScale = new Vector3(-2.5f, transform.localScale.y, 2.5f);
        }
        if (player.velocity.x > 0.1)
        {
            transform.localScale = new Vector3(2.5f, transform.localScale.y, 2.5f);
        }
        if (player.velocity.y == 0)
        {
            An.SetBool("isJumping", false);
            An.SetBool("isFalling", false);
        }
        if (player.velocity.y > 0)
        {
            An.SetBool("isJumping", true);
            An.SetBool("isFalling", false);
        }
        if (player.velocity.y < 0)
        {
            An.SetBool("isJumping", false);
            An.SetBool("isFalling", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            An.SetTrigger("isAttacking");
        }
    }
}
