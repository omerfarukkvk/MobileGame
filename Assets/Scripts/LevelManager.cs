using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Text LevelText;
    public Text ScoreText;
    public Text HealthText;
    public Slider slider;
    public Spawner spawner1;
    public Player player;
    public GameObject spawner2;
    
    public int score = 0;
    private int levelCount = 1;

    void Start()
    {
        AssigmentFunc();
        StringFunc();
    }

    void Update()
    {
        PlayerPrefs.SetInt("score", score);
        if (slider.value == slider.maxValue)
        {
            if (spawner1.j > 0)
                spawner1.j -= 0.2f;
            if (spawner1.i > 0.5f)
                spawner1.i -= 0.2f;
            //if (player.waitForPlayer > 1)
            //    player.waitForPlayer -= 0.1f;
            levelCount++;
            slider.value = 0;
            slider.maxValue += 5;
            LevelText.text = "Level " + levelCount.ToString();
        }
        if (levelCount >= 5)
        {
            spawner2.SetActive(true);
        }
        HealthText.text = "Health: " + player.Health.ToString();
        ScoreText.text = "Score: " + score.ToString();
    }

    private void AssigmentFunc()
    {
        player = GameObject.Find("PlayArea/Player").GetComponent<Player>();
        spawner1 = GameObject.Find("PlayArea/Spawners/Spawner1").GetComponent<Spawner>();
        //spawner2 = GameObject.Find("PlayArea/Spawners/Spawner2").GetComponent<Spawner>();
        slider = gameObject.GetComponent<Slider>();
    }

    private void StringFunc()
    {
        LevelText.text = "Level " + levelCount.ToString();
        ScoreText.text = "Score: " + score.ToString();
        HealthText.text = "Health: " + player.Health.ToString();
    }
}
