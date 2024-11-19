using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;

    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Update()
    {
        GetReferences();

        EnableDeathUI();
    }
    private void GetReferences()
    {
        if (playerStats == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            playerStats = FindObjectOfType<PlayerStats>();
        }
    }
    private void EnableDeathUI()
    {
        if (playerStats.Health == 0)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }
}
