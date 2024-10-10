using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BushSearch : MonoBehaviour
{
    public Animator bushAnimation;

    [SerializeField] private TextMeshPro textSearch;

    [SerializeField] private bool startSearch = false;
    [SerializeField] private bool isPressingSearch = false;



    // Start is called before the first frame update
    void Start()
    {
        if (bushAnimation == null)
        {
            bushAnimation = GetComponent<Animator>();
        }

        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            isPressingSearch = true;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            isPressingSearch = false;
        }


        if (startSearch == true && isPressingSearch == true)
        {
            bushAnimation.Play("Pine Tree Animation");

        }
        


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colliding with " + collision.transform.name);

        if (collision.gameObject.GetComponent<TopDownMovement>())
        {
            Debug.Log("start russel animation with " + collision.transform.name);

            textSearch.text = "Press E to Search!";

            startSearch = true;

        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("No longer colliding with " + collision.transform.name);

        if (collision.gameObject.GetComponent<TopDownMovement>())
        {
            Debug.Log("stop russel animation with " + collision.transform.name);

            textSearch.text = "";

            bushAnimation.Play("Idle");
            startSearch = false;
        }
    }
}
