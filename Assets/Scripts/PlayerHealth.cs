using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 1;
    public GameObject deadEffect;
    public UIController ui;


    public void DecreasePlayerHealth()
    {
        health--;
        CheckHealth();
    }
    private void CheckHealth()
    {
        if (health < 1)
        {
            ScaleTime();
            var effect = Instantiate(deadEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(effect, 0.5f);

            ui.SetActiveDeadScreen();
        }
    }
    private void ScaleTime()
    {
        Time.timeScale = 0.4f;
        
    }

}
