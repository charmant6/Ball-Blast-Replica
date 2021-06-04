using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public GameObject deadScreen;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hightScore;

    private void Start()
    {
        Time.timeScale = 1f;
        UpdateScore();
    }

    public void SetActiveDeadScreen()
    {
        StartCoroutine(DeadScreen());
    }

    IEnumerator DeadScreen()
    {
        yield return new WaitForSeconds(0.65f);
        deadScreen.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void UpdateScore()
    {
        scoreText.text = "Score : " + ScoreManager.instance.score;
        hightScore.text = "Hight Score : " + PlayerPrefs.GetInt("hightScore");
    }
}
