using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotFloor : MonoBehaviour
{
    #region Variables

    public PlayerStats PlayerStats;

    public int burnDamage;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerStats == null)
        {
            PlayerStats = FindObjectOfType<PlayerStats>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerStats>())
        {
            PlayerStats.Health -= burnDamage;
        }
    }
}
