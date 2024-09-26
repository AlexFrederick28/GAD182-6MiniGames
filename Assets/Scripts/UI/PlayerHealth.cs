using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public TextMeshPro playerHealth;
    public TextMeshPro switchesTotal;

    public PlayerStats playerStats;
    public EscapeDoor switchCount;

    // Start is called before the first frame update
    void Start()
    {
        if (playerStats == null)
        {
            switchCount = FindObjectOfType<EscapeDoor>();
            playerStats = FindAnyObjectByType<PlayerStats>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        switchesTotal.text = switchCount.activatedSwitches + " / 4";
        playerHealth.text = "HP = " + playerStats.playerHealth;
    }
}
