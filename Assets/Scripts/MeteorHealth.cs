using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MeteorHealth : MonoBehaviour
{
    public int health;
    public TextMeshPro healthText;
    public Missile missile;
    
    void Start()
    {
        healthText.text = health.ToString();
    }
    public void TakeDamage()
    {
        health -= missile.damage;
        healthText.text = health.ToString();
        CheckHealth();
    }
    private void CheckHealth()
    {
        if (health < 1)
        {
            Destroy(gameObject);
        }
    }

}
