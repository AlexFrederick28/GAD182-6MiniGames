using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bush : MonoBehaviour, ISearchInterface
{
    public Animator bushAnimation; // gets this automatically (Make sure its attached to parent)
    public TextMeshPro searchTutorial; // gets this automatically (Make sure its attached as child)

    [SerializeField] private bool inSearchArea = false;

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
            searchTutorial = GetComponentInChildren<TextMeshPro>();
            bushAnimation = GetComponent<Animator>();
        }

        if (isPressingSearch() == true && inSearchArea == true)
        {
            bushAnimation.Play("Bush Animation"); // Change this to what animation you want to play (Has to be attached in animator) - Make sure it is identical word for word
        }

    }
}
