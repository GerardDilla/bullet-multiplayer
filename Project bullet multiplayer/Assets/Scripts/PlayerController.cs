using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Vector2 direction;

    // private Animator animator;
    // Start is called before the first frame update

    private void Start()
    {
        // animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
            // animator.SetInteger("Direction", 3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
            // animator.SetInteger("Direction", 2);
        }

        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1;
            // animator.SetInteger("Direction", 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction.y = -1;
            // animator.SetInteger("Direction", 0);
        }

        direction.Normalize();
        // animator.SetBool("IsMoving", dir.magnitude > 0);

        PlayerMove();

    }
    public void PlayerMove()
    {
        GetComponent<Rigidbody2D>().velocity = speed * direction;
    }

}
