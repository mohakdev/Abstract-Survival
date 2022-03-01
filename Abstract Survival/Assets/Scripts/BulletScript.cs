using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D bulletBody;
    private AudioSource audioPlayer;
    public int Speed;
    private void Awake()
    {
        bulletBody = GetComponent<Rigidbody2D>();
        audioPlayer = GetComponent<AudioSource>();
    }
    public void Shoot(Vector2 direction)
    {
        bulletBody.AddForce(direction * Speed);
        audioPlayer.Play();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
