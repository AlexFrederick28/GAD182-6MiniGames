using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EscapeDoor : MonoBehaviour
{
    #region Variables

    public bool openDoor = false;
    public int activatedSwitches = 0;

    public TextMeshPro winTextEscape;

    public int ActiveSwitches
    {
        get
        {
            return activatedSwitches;
        }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            if (value > 4)
            {
                value = 4;
            }

            activatedSwitches = value;

        }
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activatedSwitches == 4)
        {
            winTextEscape.text = "The Door has Opened!";

            openDoor = true;
            this.gameObject.SetActive(false);
        }
    }
}
