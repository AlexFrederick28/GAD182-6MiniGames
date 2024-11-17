using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHand : MonoBehaviour
{
    [SerializeField] private AudioSource reviveSound;
    [SerializeField] private AudioClip playerReviveAudio;

    private void Start()
    {
        reviveSound.clip = playerReviveAudio;
        reviveSound.PlayOneShot(playerReviveAudio);

        Destroy(gameObject, 2);
    }
}
