using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Animator animator;
    public float speed = 2f;
    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position += new Vector3(moveDirection.x, moveDirection.y, 0) * Time.fixedDeltaTime * speed;

    }


    public void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();

        if (moveDirection != Vector2.zero)
        {
            animator.SetFloat("XInput", moveDirection.x);
            animator.SetFloat("YInput", moveDirection.y);
        }
    }
}
