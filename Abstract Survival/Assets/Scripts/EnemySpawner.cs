using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    private void Start()
    {
        StartCoroutine(MakeEnemies());
    }
    IEnumerator MakeEnemies()
    {
        while (true)
        {
            int RandomNumber = Random.Range(1, transform.childCount);
            GameObject RandomObject = transform.GetChild(RandomNumber).gameObject;
            GameObject EnemyInstance = Instantiate(Enemy, RandomObject.transform.position, RandomObject.transform.rotation);
            yield return new WaitForSeconds(5);
        }
    }
}
