using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bush : MonoBehaviour, ISearchInterface
{
    public Animator bushAnimation; // gets this automatically (Make sure its attached to parent)
    public TextMeshPro searchTutorial; // gets this automatically (Make sure its attached as child)

    public TreasureFound treasureFound;

    public bool inSearchArea = false;

    public bool searchedBush = false;


    public bool isPressingSearch()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pressing E to Search");
            return true;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            return false;
        }

        return false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<TopDownMovement>())
        {
            searchTutorial.text = "Press E to Search!";
            inSearchArea = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<TopDownMovement>())
        {
            searchTutorial.text = "";
            inSearchArea = false;
        }
    }

    private void Update()
    {
        if (bushAnimation == null)
        {
            treasureFound = GetComponent<TreasureFound>();
            searchTutorial = GetComponentInChildren<TextMeshPro>();
            bushAnimation = GetComponent<Animator>();
        }

        if (isPressingSearch() == true && inSearchArea == true)
        {
            bushAnimation.Play("Bush Animation"); // Change this to what animation you want to play (Has to be attached in animator) - Make sure it is identical word for word
            searchedBush = true;
            treasureFound.treasureGathered = true;
        }
        if (searchedBush == true && treasureFound.treasureCollected == false)
        {
            searchTutorial.text = "Nothing Found!";
            Debug.Log("There is nothing here!");
        }
        if (searchedBush == true && treasureFound.treasureCollected == true)
        {
            searchTutorial.text = "Gold Found!";
            Debug.Log("You Found Treasure!");
        }


    }
}
