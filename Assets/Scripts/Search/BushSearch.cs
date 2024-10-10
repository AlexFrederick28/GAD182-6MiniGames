using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BushSearch : MonoBehaviour
{
    public Animator bushAnimation;

    private SpriteRenderer bushRenderActive;

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

        if (startSearch == false)
        {
            bushAnimation.Play("Idle");
        }

        if (isPressingSearch == true)
        {
            bushAnimation.Play("Large Pine Animation");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colliding with " + collision.transform.name);

        if (collision.gameObject.GetComponent<TopDownMovement>())
        {
            Debug.Log("start russel animation with " + collision.transform.name);

            
            startSearch = true;
        }

    }
}
