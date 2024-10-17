using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface ISearchInterface 
{
    

    protected bool IsPressingSearch() // Requirement for player to be pressing E to start Searching
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player is pressing E");
            return true;
        }
        else
        {
            return false;
        }

    }

    

    protected void StartSearching(string animationName)
    {
        
    }





}
