using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLobby : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<TopDownMovement>())
        {
            Debug.Log("Loading Lobby");

            SceneManager.LoadScene(0);
        }
    }
}
