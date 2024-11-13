using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreasureHunt : MonoBehaviour
{
    public TextMeshPro playerHealth;
    public TextMeshPro treasureAmount;

    public PlayerStats playerStats;
    public TreasureFound treasureFound;

    public GameObject damageUI;
    public int allTreasureCount = 0;



    public void Update()
    {
        GetScripts();

        ShowHealth();

        AmountTreasure();

        DamageUI();
    }

    public void ShowHealth()
    {
        playerHealth.text = "HP = " + playerStats.Health;
    }

    public void AmountTreasure()
    {
        treasureAmount.text = allTreasureCount.ToString();
    }

    public void DamageUI()
    {
        if (playerStats.playerHealth == 0)
        {
            damageUI.SetActive(true);
        }
        if (playerStats.playerHealth != 0)
        {
            damageUI.SetActive(false);
        }
    }

    public void GetScripts()
    {
        if (playerHealth == null)
        {
            treasureFound = FindObjectOfType<TreasureFound>();
            playerHealth = GetComponent<TextMeshPro>();
            playerStats = FindFirstObjectByType<PlayerStats>();
        }
    }
}
