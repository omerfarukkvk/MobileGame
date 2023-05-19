using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Text highScoreText;
    public Player player;

    public void Setup()
    {
        gameObject.SetActive(true);
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
    }
}
