using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public TreasureHunt treasureHunt;

    [SerializeField]private bool exitEnabled = false;
    [SerializeField]private bool atDoor = false;

    private void Update()
    {
        WinConditionDoor();
    }


    public void WinConditionDoor()
    {
        if (treasureHunt == null)
        {
            treasureHunt = FindAnyObjectByType<TreasureHunt>();
        }

        if (treasureHunt.allTreasureCount == 4)
        {
            exitEnabled = true;
        }

        if (exitEnabled == true && atDoor == true)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerStats>())
        {
            atDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerStats>())
        {
            atDoor = false;
        }
    }
}
