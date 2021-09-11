using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int id;
    public string username;
    public float gravity = 0;
    public float moveSpeed = 4f;
    private Rigidbody2D myRigidbody;
    private Vector3 change;

    private bool[] inputs;
    public int moveDirection;
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        moveSpeed *= Time.deltaTime;
    }

    public void Initialize(int _id, string _username)
    {
        id = _id;
        username = _username;

        inputs = new bool[5];
    }

    public void FixedUpdate()
    {
        change = Vector3.zero;
        moveDirection = 0;
        if (inputs[0])
        {
            change.y += 1;
            moveDirection = 1;
        }
        if (inputs[1])
        {
            change.y -= 1;
            moveDirection = 2;
        }
        if (inputs[2])
        {
            change.x -= 1;
            moveDirection = 3;
        }
        if (inputs[3])
        {
            change.x += 1;
            moveDirection = 4;
        }
        Move(change);
    }

    private void Move(Vector3 _inputDirection)
    {
        myRigidbody.MovePosition(
            transform.position + change * moveSpeed
            );
        ServerSend.PlayerPosition(this);
    }

    public void SetInput(bool[] _inputs)
    {
        inputs = _inputs;
    }
}
