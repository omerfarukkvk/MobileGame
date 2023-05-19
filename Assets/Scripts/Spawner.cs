using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Enemy;
    public float i, j;
    
    void Start()
    {
        StartCoroutine(SpawnerTime());
    }

    public IEnumerator SpawnerTime()
    {
        Vector3 spawnerPos = new Vector3(Random.Range(2.2f, -2.2f), 6f, 0);
        yield return new WaitForSeconds(Random.Range(j, i));
        Instantiate(Enemy, spawnerPos, Enemy.transform.rotation);
        StartCoroutine(SpawnerTime());
    }
}
