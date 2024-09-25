using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitFallTrap : MonoBehaviour
{
    #region Variables

    public float pitFallDamage = 100;
    public float transitionSpeed = 0.001f;
    public bool trapActive;

    public PlayerStats playerStats;
    public Sprite pitEnabled;
    public Sprite pitDisabled;

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
        #region PlayerFall
        if (trapActive == true) // falling into this trap will kill the player
        {

            playerStats.transform.position = transform.position;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = pitEnabled;

        }
        if (trapActive == true && playerStats.transform.localScale.x > 0.1) // sets player scale smaller (Looks like falling)
        {

            Vector3 fallingScale = new Vector3(0.1f, 0.1f, 0);
            fallingScale = fallingScale.normalized;
            playerStats.transform.localScale -= fallingScale * transitionSpeed * Time.deltaTime;

        }
        if (trapActive == true && playerStats.transform.localScale.x == 0.1) // makes sure player doesnt get too small and hits a bottom
        {
            Vector3 atBottom = new Vector3(0.1f, 0.1f, 0);

            playerStats.transform.localScale = atBottom;
        }
        #endregion
    }

    public void OnTriggerEnter2D(Collider2D collision) // trigger is used to detect player without collision
    {
        if (collision.transform.GetComponent<TopDownMovement>())
        {
            playerStats.Health -= pitFallDamage;
            trapActive = true;
        }
    }
}
