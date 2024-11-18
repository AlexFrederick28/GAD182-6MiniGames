using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnOne;
    [SerializeField] private GameObject spawnTwo;
    [SerializeField] private GameObject spawnThree;

    [SerializeField] private GameObject prefabSpriteEnemy;

    public List<GameObject> SpawnCap = new List<GameObject>();

   
    private void SpawnEnemies()
    {
        if (SpawnCap.Count == 0)
        {
            Instantiate(prefabSpriteEnemy, spawnOne.transform.position, Quaternion.identity);
            Instantiate(prefabSpriteEnemy, spawnTwo.transform.position, Quaternion.identity);
            Instantiate(prefabSpriteEnemy, spawnThree.transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<PlayerStats>())
        {
            SpawnEnemies();
        }
    }
}
