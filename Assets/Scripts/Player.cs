using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameOverManager gameOver;
    public float waitForPlayer;
    public int Health = 3;
    public int CoinCount = 0;
    public int highScore;
    public GameObject Bullet;
    
    void Start()
    {
        //waitForPlayer = PlayerPrefs.GetFloat("waitForPlayer");  //hata burda
        highScore = PlayerPrefs.GetInt("highScore");
        CoinCount = PlayerPrefs.GetInt("Coins");
        StartCoroutine(BulletFunc());
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("waitForPlayer", waitForPlayer);
        PlayerPrefs.SetInt("Coins", CoinCount);
        if (Health == 0)
        {
            if (highScore > PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("highScore", highScore);
            }
            else
            {
                PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
            }
            Destroy(gameObject);
            Time.timeScale = 0;
            gameOver.Setup();
        }
    }
    public IEnumerator BulletFunc()
    {
        yield return new WaitForSeconds(waitForPlayer);
        Instantiate(Bullet, gameObject.transform.position, Quaternion.identity);
        StartCoroutine(BulletFunc());
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Health--;
            Handheld.Vibrate();
        }
    }
}
