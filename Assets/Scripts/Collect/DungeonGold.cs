using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGold : MonoBehaviour
{
    public PlayerWin PlayerWin;

    public bool collectedGold = false;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<PlayerStats>())
        {
            PlayerWin.collectedGold += 1;

            gameObject.SetActive(false);
        }
    }

    public void Start()
    {
        if (PlayerWin == null)
        {
            PlayerWin = FindObjectOfType<PlayerWin>();  
        }
    }
}
