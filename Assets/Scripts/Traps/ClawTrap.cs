using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawTrap : MonoBehaviour
{

    // Claw trap 

    #region Variables

    public float clawDamage = 50;
    public bool trapActive;

    public PlayerStats playerStats;


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (playerStats == null) // grabs player script automatically
        {
            playerStats = FindAnyObjectByType<PlayerStats>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (trapActive == true) // keeps hold of player
        {
            playerStats.transform.position = transform.position;
        }
        if (trapActive == true && Input.GetKeyDown(KeyCode.Mouse0)) // lets go of player (Should put UI for struggle telling player to escape)
        {
            trapActive = false;
        }

        // IDEA - Trap does less damage, although occurs everytime the player struggles. Struggling to get out will be chance based.
    }



    public void OnTriggerEnter2D(Collider2D collision) // trigger is used to detect player without collision
    {
        if (collision.transform.GetComponent<TopDownMovement>())
        {
            playerStats.Health -= clawDamage;
            trapActive = true;
        }
    }
}
