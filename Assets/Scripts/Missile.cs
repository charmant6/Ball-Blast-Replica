using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour

{
    public int speed = 20;
    public int damage = 25;
    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = Vector2.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Missile") || other.CompareTag("Meteor"))
        {
            Destroy(gameObject);
        }
    }
}
