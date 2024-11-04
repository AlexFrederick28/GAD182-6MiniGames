using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    #region Variables

    public bool switchActive = true;
    private int addOne = 1;

    public EscapeDoor openDoor;
    public Sprite offSwitch;

    public PlayerStats playerStats;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (openDoor == null) // grabs components automatically
        {
            playerStats = FindObjectOfType<PlayerStats>();
            openDoor = FindObjectOfType<EscapeDoor>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (switchActive == false && addOne == 1 && playerStats.needsRevive == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = offSwitch;
            openDoor.ActiveSwitches += 1;
            addOne = 0;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerStats>() && switchActive == true && playerStats.needsRevive == false)
        {
            switchActive = false;
        }
    }
}
