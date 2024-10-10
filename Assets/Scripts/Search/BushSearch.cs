using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushSearch : MonoBehaviour
{
    private Animator bushAnimation;

    private SpriteRenderer bushRenderActive;



    // Start is called before the first frame update
    void Start()
    {
        if (bushAnimation == null)
        {
            bushAnimation = GetComponent<Animator>();
        }

        bushAnimation.StopRecording();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
