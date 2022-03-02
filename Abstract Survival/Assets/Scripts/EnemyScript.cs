using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("Enemy Settings")]
    public int Speed;
    public float StoppingDistance;
    private GameObject Player;
    private Vector3 Direction;
    private Rigidbody2D EnemyBody;
    public GameObject KillEffect;
    private AudioSource audioPlayer;
    private void Awake()
    {
        EnemyBody = GetComponent<Rigidbody2D>();
        Player = GameObject.Find("Player");
        audioPlayer = GameObject.Find("EnemySoundProducer").GetComponent<AudioSource>();
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
    private void OnCollisionEnter2D(Collision2D other)
    {
        print("Collision Works");
        if (other.gameObject.name == "Bullet(Clone)")
        {
            audioPlayer.Play();
            GameObject KillEffectClone = Instantiate(KillEffect, transform.position, transform.rotation);
            KillEffectClone.SetActive(true);
            Destroy(gameObject);
        }
    }
}
