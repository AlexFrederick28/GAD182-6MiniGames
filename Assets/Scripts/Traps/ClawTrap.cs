using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawTrap : MonoBehaviour
{

    // Claw trap 

    #region Variables

    public float clawDamage = 25;
    public bool trapActive;

    public PlayerStats playerStats;
    public Sprite clawEnabled;
    public Sprite clawDisabled;


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (playerStats == null) // grabs components automatically
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
            this.gameObject.GetComponent<SpriteRenderer>().sprite = clawEnabled;
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }
        if (trapActive == true && Input.GetKeyDown(KeyCode.Mouse0)) // lets go of player (Should put UI for struggle telling player to escape)
        {
            trapActive = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = clawDisabled;
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
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
