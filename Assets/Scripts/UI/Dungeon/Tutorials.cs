using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorials : MonoBehaviour
{
    #region Variables

    public bool firstTimeShown = false;

    public TextMeshPro revivingTutorial;
    

    public PlayerStats playerStats;
    

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (playerStats == null)
        {
            
            playerStats = FindObjectOfType<PlayerStats>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStats.playerHealth == 0 && firstTimeShown == false)
        {
            revivingTutorial.text = "Find a Light Source to Revive!";

            firstTimeShown = true;
        }
        if (firstTimeShown == true && playerStats.playerHealth == 100)
        {
            revivingTutorial.text = null;
        }

       
    }
}
