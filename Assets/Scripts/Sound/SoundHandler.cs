using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundHandler : MonoBehaviour
{
    [SerializeField] private AudioSource AmbienceAudioPlayer;

    [SerializeField] private AudioClip WindAmbience;

    [SerializeField] private GameObject playerDeathPrefab;
    [SerializeField] private GameObject playerRevivePrefab;

    [SerializeField] private bool playedDeathSound = false;

    public PlayerStats PlayerStats;

    private void Start()
    {
        GetReferences();

        PlayAmbienceSound();

    }

    private void Update()
    {
        PlayDeathSound();
    }

    private void PlayAmbienceSound()
    {
        AmbienceAudioPlayer.clip = WindAmbience;
        AmbienceAudioPlayer.Play();
    }

    private void PlayDeathSound()
    {
        
        if (PlayerStats.playerHealth != 0)
        {
            playedDeathSound = false;
        }
        else if (PlayerStats.playerHealth == 0 && playedDeathSound == false)
        {
            Instantiate(playerDeathPrefab, transform.position, Quaternion.identity);
            playedDeathSound = true;
        }
    }

    public void PlayReviveSound()
    {
        Instantiate(playerRevivePrefab, transform.position, Quaternion.identity);
    }

    private void GetReferences()
    {
        if (PlayerStats == null)
        {
            PlayerStats = FindObjectOfType<PlayerStats>();
        }
    }
}
