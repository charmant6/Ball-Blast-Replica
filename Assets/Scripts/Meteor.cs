using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Rigidbody2D rigid;
    public MeteorHealth meteorHealth;
    public float jumpForce;
    private PlayerHealth playerHealth;
    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        rigid.AddForce(Vector2.right * Random.Range( 200f, -200f));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Missile"))
        {
            meteorHealth.TakeDamage();
        }
        if (other.CompareTag("Ground"))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpForce);
            CheckGroundTouch();
        }
        else if (other.CompareTag("RightLimit"))
        {
            rigid.velocity = Vector2.left * 5f;
        }
        else if (other.CompareTag("LeftLimit"))
        {
            rigid.velocity = Vector2.right * 5f;
        }
        else if (other.CompareTag("Player"))
        {
            playerHealth.DecreasePlayerHealth();
        }
        
    }
    private void CheckGroundTouch()
    {
        jumpForce -= 0.4f;
        if (jumpForce < 16)
        {
            jumpForce = 16f;
        }
    }

}
