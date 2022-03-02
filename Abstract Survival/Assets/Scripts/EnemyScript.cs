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
        Vector3 dir = Player.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + 270;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if (Vector2.Distance(transform.position, Player.transform.position) > StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
        }
    }
}
