using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{
    public EscapeDoor EscapeDoor;

    public BoxCollider2D winCollider;

    public int collectedGold;

    public TextMeshPro Gold;
    public TextMeshPro Switches;
    public TextMeshPro winText;

    public void Start()
    {
        if (EscapeDoor == null)
        {
            winCollider = GetComponent<BoxCollider2D>();
            EscapeDoor = FindObjectOfType<EscapeDoor>();
        }
    }

    public void Update()
    {
        Gold.text = "" + collectedGold;

        Switches.text = "" + EscapeDoor.activatedSwitches;

        if (collectedGold == 3 && EscapeDoor.activatedSwitches == 4)
        {
            winText.text = "The Door Has Opened!";

            winCollider.enabled = true;
        }
    }
}
