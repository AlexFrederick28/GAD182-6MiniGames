using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    #region Variables

    public float moveSpeed;
    public Rigidbody2D playerRigid;
    public SpriteRenderer playerSprite;
    public Vector2 moveInput;

    #endregion



    // Start is called before the first frame update
    void Start()
    {
        if (playerRigid == null) // Gets Rigidbody of player automatically
        {
            playerSprite = GetComponent<SpriteRenderer>();
            playerRigid = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        // movement updates

        moveInput.x = Input.GetAxisRaw("Horizontal"); // left right
        moveInput.y = Input.GetAxisRaw("Vertical"); // up down

        moveInput.Normalize(); // keeps movement fluid

        playerRigid.velocity = moveInput * moveSpeed; // enabling movement

        if (playerRigid.velocity.x > 0)
        {
            playerSprite.flipX = false;
        }
        if (playerRigid.velocity.x < 0)
        {
            playerSprite.flipX = true;
        }
    }
}
