using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSounds : MonoBehaviour
{
    [SerializeField] private AudioSource deathSoundPlayer;
    [SerializeField] private AudioClip playerDeathSound;

    private void Start()
    {
        deathSoundPlayer.clip = playerDeathSound;
        deathSoundPlayer.PlayOneShot(playerDeathSound);

        Destroy(gameObject, 2);
    }
}
