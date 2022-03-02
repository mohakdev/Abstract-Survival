using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("Enemy Settings")]
    public int Speed;
    public float StoppingDistance;
    public GameObject Player;
    private Vector3 Direction;
    private Rigidbody2D EnemyBody;
    private void Awake()
    {
        EnemyBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) > StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
        }
    }
}
