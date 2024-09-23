using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    // PLAYER STATS

    #region Variables

    public float playerHealth = 100; // player health value

    public float Health // restrictions for player health value
    {
        get
        {
            return playerHealth;
        }
        set
        {
            if (value > 100)
            {
                value = 100;
            }
            if (value < 0)
            {
                value = 0;
            }

            playerHealth = value;
        }
    }


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Stats Active");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
