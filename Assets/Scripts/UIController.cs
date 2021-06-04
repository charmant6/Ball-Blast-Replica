using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject deadScreen;

    private void Start()
    {
        Time.timeScale = 1f;
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

}
