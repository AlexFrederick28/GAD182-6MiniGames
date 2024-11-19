using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveSound : MonoBehaviour
{
    [SerializeField] private AudioSource reviveSoundPlayer;
    [SerializeField] private AudioClip playerReviveSound;

    private void Start()
    {
        reviveSoundPlayer.clip = playerReviveSound;
        reviveSoundPlayer.PlayOneShot(playerReviveSound);

        Destroy(gameObject, 2);

    }
}
