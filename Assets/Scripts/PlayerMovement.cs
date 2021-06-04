using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D rigid;
    public WheelMove wheel;
    

    void FixedUpdate()
    {
        PlayerMovment();
        ChechWheelRotation();


    }
    private void PlayerMovment()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(h * speed, rigid.velocity.y);
    }

    private void ChechWheelRotation()
    {
        if (rigid.velocity.x > 0)
        {
            wheel.WheelRightRotation();
        }
        else if (rigid.velocity.x < 0)
        {
            wheel.WheelLeftRotation();
        }
        else
        {
            wheel.StopWheelRotation();
        }
    }

}
