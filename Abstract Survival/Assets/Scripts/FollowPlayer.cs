using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform Player;
    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }
    void LateUpdate()
    {
        //If player object gets deleted when we kill player it wont give an error
        if (!Player)
        {
            return;
        }
        tempPos = transform.position;
        tempPos.x = Player.position.x;
        tempPos.y = Player.position.y;
        //Setting the position of Camera to player's x and y coordinates
        transform.position = tempPos;
    }
}
