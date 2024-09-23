using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using UnityEngine.U2D;

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
        if (playerRigid == null) // Gets Rigidbody/Animator/Sprite of player automatically
        {
            animator = GetComponent<Animator>();
            playerSprite = GetComponent<SpriteRenderer>();
            playerRigid = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        #region Movement
        // MOVEMENT UPDATES

        moveInput.x = Input.GetAxisRaw("Horizontal"); // left right
        moveInput.y = Input.GetAxisRaw("Vertical"); // up down

        moveInput.Normalize(); // keeps movement fluid

        playerRigid.velocity = moveInput * moveSpeed; // enabling movement


        // MOVEMENT ANIMATIONS

        if (moveInput.y > 0 && moveInput.x == 0) // Plays Animation and rotates character
        {

            playerRigid.MoveRotation(180);
            animator.Play("Slime MOVE");
            isRunning = true;

        }
        if (moveInput.y < 0 && moveInput.x == 0) // Plays Animation and rotates character
        {

            playerRigid.MoveRotation(0);
            animator.Play("Slime MOVE");
            isRunning = true;

        }
        if (moveInput.y == 0 && moveInput.x > 0) // Plays Animation and rotates character
        {

            playerRigid.MoveRotation(90);
            animator.Play("Slime MOVE");
            isRunning = true;

        }
        if (moveInput.y == 0 && moveInput.x < 0) // Plays Animation and rotates character
        {

            playerRigid.MoveRotation(-90);
            animator.Play("Slime MOVE");
            isRunning = true;

        }
        if (moveInput.y == 0 && moveInput.x == 0) // turns off animations when still
        {
            isRunning = false;
        }

        if (isRunning == false) // Plays Idle Animation
        {
            animator.Play("Idle");
        }

        if (playerRigid.angularVelocity != 0) // stops player from being manipulated by collision of objects
        {
            playerRigid.angularVelocity = 0;
        }
        #endregion







    }
}
