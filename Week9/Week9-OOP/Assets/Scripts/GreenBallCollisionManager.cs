using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // change ball size
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}

