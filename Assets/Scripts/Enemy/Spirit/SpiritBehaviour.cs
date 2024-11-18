using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script gives the "Spirit Enemy" movement
/// </summary>
public class SpiritBehaviour : MonoBehaviour
{

    [SerializeField] private float trackingSpeed;

    private Transform playerTransform;

    private PlayerStats playerStats;

    [SerializeField] private AudioSource spiritAudioSource;

    [SerializeField] private AudioClip fairyDustMove;

    public Spirit_Spawner Spirit_Spawner;

    private void Start()
    {
        GetReferences();

        SpiritSound();

        Spirit_Spawner.SpawnCap.Add(gameObject);
    }

    private void Update()
    {
        MoveToPlayer();

    }

    private void MoveToPlayer()
    {
        Vector3 moveToPlayer = (playerTransform.position - transform.position).normalized;

        transform.position += moveToPlayer * trackingSpeed * Time.deltaTime;

        transform.LookAt(playerTransform.position);
    }

    private void SpiritSound()
    {
        spiritAudioSource.clip = fairyDustMove;
        spiritAudioSource.Play();
    }

    public void GetReferences()
    {
        if (playerTransform == null)
        {
            Spirit_Spawner = FindObjectOfType<Spirit_Spawner>();
            playerStats = FindObjectOfType<PlayerStats>();
            playerTransform = FindObjectOfType<PlayerStats>().transform;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<PlayerStats>())
        {
            playerStats.Health -= 5;

            Spirit_Spawner.SpawnCap.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
