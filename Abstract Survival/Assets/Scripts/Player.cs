using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BulletScript bulletCode;
    [Header("Player Settings :")]
    public int MovementSpeed;
    public int TurnSpeed;
    private Rigidbody2D mybody;
    private float TurnDirection;
    private bool thrusting;
    //Variables Req For Dashing
    private float activeSpeed;
    public float dashSpeed;
    public float dashLength = 0.5f, dashCoolDown = 2f;
    float DashCounter;
    float DashCoolCounter;
    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        activeSpeed = MovementSpeed;
    }

    void Update()
    {
        thrusting = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        //Setting the float var TurnDirection depending upon Input
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            TurnDirection = 1.0f;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            TurnDirection = -1.0f;
        }
        else
        {
            TurnDirection = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        //If Player presses space then dash
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Dashing");
            if (DashCoolCounter <= 0 && DashCounter <= 0)
            {
                activeSpeed = dashSpeed;
                DashCounter = dashLength;
            }
        }
        if (DashCounter > 0)
        {
            DashCounter -= Time.deltaTime;
            if (DashCounter <= 0)
            {
                activeSpeed = MovementSpeed;
                DashCoolCounter = dashCoolDown;
            }
        }
        if (DashCoolCounter > 0)
        {
            DashCoolCounter -= Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        if (thrusting)
        {
            mybody.AddForce(this.transform.up * activeSpeed);
        }
        if (TurnDirection != 0.0f)
        {
            mybody.AddTorque(TurnDirection * TurnSpeed * Time.deltaTime);
        }
    }
    void Shoot()
    {
        BulletScript Bullet = Instantiate(this.bulletCode, this.transform.position, this.transform.rotation);
        Bullet.Shoot(transform.up);
    }
}
