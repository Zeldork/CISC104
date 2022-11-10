using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // change ball color
        GetComponent<Renderer>().material.color = new Color(0, 206, 209);
    }
}

