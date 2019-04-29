using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Polarity
{
    Up = 1,Down=-1
}


[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{

    Rigidbody2D rBody;
    public Polarity polarity;
    private int gravityDirection;
    private int jumpDirection;
    public float jumpSpeed;
    bool grounded = true;

    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        gravityDirection = (int)polarity;
        rBody.gravityScale = gravityDirection;
        jumpDirection = -gravityDirection;
    }

    public void Jump()
    {
        if (grounded)
        {
            rBody.velocity = new Vector2(0, jumpDirection * jumpSpeed);
            grounded = false;
        }
    }
  /*  void Update()
    {
        Debug.Log("Player Jumped");
    }
    */
        private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }

}
