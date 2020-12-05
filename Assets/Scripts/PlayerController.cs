using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float WalkSpeed;
    public float JumpForce = 5;
    float Move;

    private Transform _transform;
    private Rigidbody2D _rigidbody;
    private bool isGrounded;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        transform.Translate(Move, 0, 0);

    }

    public void MoveRight() 
    {
        Move = WalkSpeed;
    }
    public void MoveLeft()
    {
        Move = -WalkSpeed;
    }
    public void Jump() 
    {
        if(isGrounded)
        _rigidbody.AddForce(new Vector2(0, JumpForce),ForceMode2D.Impulse);
    }
    public void Stop()
    {
        Move = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        isGrounded = false;
    }

}