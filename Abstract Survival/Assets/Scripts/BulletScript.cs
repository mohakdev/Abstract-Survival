using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D bulletBody;
    public int Speed;
    private void Awake()
    {
        bulletBody = GetComponent<Rigidbody2D>();
    }
    public void Shoot(Vector2 direction)
    {
        bulletBody.AddForce(direction * Speed);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
