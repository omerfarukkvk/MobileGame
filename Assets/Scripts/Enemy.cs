using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject[] Loot;
    public Slider slider;
    public LevelManager level;
    public float Speed;
    private int i;

    void Start()
    {
        level =  GameObject.Find("Canvas/Level").GetComponent<LevelManager>();
        slider = GameObject.Find("Canvas/Level").GetComponent<Slider>();
        Destroy(gameObject, 5f);
    } 
    void Update()
    {
        gameObject.transform.position = new Vector2(transform.position.x, transform.position.y - Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        i = Random.Range(1, 11);
        if (i <= 10)
        {
            Instantiate(Loot[0], gameObject.transform.position, Quaternion.identity);
        }
        if (other.gameObject.tag == "Bullet")
        {
            level.score += 10;
            slider.value++;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
