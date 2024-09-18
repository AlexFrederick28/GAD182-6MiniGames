using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    #region Variables

    public float moveSpeed;
    public Rigidbody2D playerRigid;
    public SpriteRenderer playerSprite;
    Animator animator;
    public Vector2 moveInput;

    public bool isRunning = false;

    #endregion



    // Start is called before the first frame update
    void Start()
    {
        if (playerRigid == null) // Gets Rigidbody of player automatically
        {
            animator = GetComponent<Animator>();
            playerSprite = GetComponent<SpriteRenderer>();
            playerRigid = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        animator.StopPlayback();
        // movement updates

        moveInput.x = Input.GetAxisRaw("Horizontal"); // left right
        moveInput.y = Input.GetAxisRaw("Vertical"); // up down

        moveInput.Normalize(); // keeps movement fluid

        playerRigid.velocity = moveInput * moveSpeed; // enabling movement

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("Slime MOVE");
            playerSprite.flipY = true;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("Slime MOVE");
            playerSprite.flipY = false;
        }










    }
}
