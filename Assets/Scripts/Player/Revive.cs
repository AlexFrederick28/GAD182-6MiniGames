using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Revive : MonoBehaviour
{
    #region Variables

    public Light2D lightSource; // light2D to enable/disable lighting

    public PlayerStats playerStats; // referencing the player

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (playerStats == null) // gets components automatically
        {
            lightSource = GetComponentInChildren<Light2D>();
            playerStats = FindObjectOfType<PlayerStats>();
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision) // player can soak up light source to gain back HP
    {
       if (collision.GetComponent<PlayerStats>())
        {
            if (playerStats.playerHealth == 0 && lightSource.enabled == enabled)
            {
                playerStats.playerHealth = 100;
                lightSource.enabled = false;
            }
        }
    }
}
