using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreasureDungeon : MonoBehaviour
{
    // This is a scene loader using collision detection for Treasure Dungeon


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("awake");
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("colliding");

        if (collision.transform.GetComponent<TopDownMovement>())
        {
            Debug.Log("Touching Treasure Forest");

            SceneManager.LoadScene(3);
        }
    }
}
