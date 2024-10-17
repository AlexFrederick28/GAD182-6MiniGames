using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class LargePineTree : MonoBehaviour, ISearchInterface
{
    [SerializeField] private bool WithinSearchArea = false;
    [SerializeField] private Animator bushAnimation;

    private bool IsPressingSearch() // Requirement for player to be pressing E to start Searching
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

    OnTriggerEnter2D ISearchInterface.InSearchArea(Collider2D collision)
    {

        Debug.Log("Player Entered Search Area");

        if (collision.gameObject.GetComponent<TopDownMovement>())
        {
            WithinSearchArea = true;
        }

        return null;
    }

    OnTriggerExit2D ISearchInterface.OutsideSearchArea(Collider2D collision)
    {

        Debug.Log("Player Exited Search Area");

        if (collision.gameObject.GetComponent<TopDownMovement>())
        {
            WithinSearchArea = false;
        }

        return null;
    }

    void ISearchInterface.StartSearching()
    {
        if (bushAnimation == null)
        {
            bushAnimation = GetComponent<Animator>();
        }

        if (WithinSearchArea == true && IsPressingSearch() == true)
        {
            bushAnimation.Play("Pine Tree Animation");
        }
    }

   
}
