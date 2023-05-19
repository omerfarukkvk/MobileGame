using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClickPlay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Play Area");
    }

    public void OnClickShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void OnClickStory()
    {
        
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickPause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void OnClickContinue()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
