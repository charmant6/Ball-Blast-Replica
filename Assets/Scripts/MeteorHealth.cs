using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MeteorHealth : MonoBehaviour
{
    public int health;
    public TextMeshPro healthText;
    public Missile missile;
    private UIController ui;

    void Start()
    {
        ui = GameObject.FindGameObjectWithTag("Canvas").GetComponent<UIController>();
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
            ScoreManager.instance.IncreaseScore(10);
            ui.UpdateScore();
            Destroy(gameObject);
        }
    }

}
