using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public TextMeshPro playerHealth;

    public PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        if (playerStats == null)
        {
            playerStats = FindAnyObjectByType<PlayerStats>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = "HP = " + playerStats.playerHealth;
    }
}
