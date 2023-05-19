using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    
    void Start()
    {
        Destroy(gameObject, 5f);    
    }

    void Update()
    {
        gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + Speed * Time.deltaTime);
    }
}
