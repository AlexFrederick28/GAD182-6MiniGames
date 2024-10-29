using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureFound : MonoBehaviour
{

    #region variables

    public bool treasureCollected = false;
    public bool treasureGathered = false;

    public bool treasureInBush = false; // CHANGE THIS TO TRUE IF YOU WANT THERE TO BE GOLD


    public PineTree pineTree;
    public CherryBush cherryBush;
    public Bush bush;
    public LargePineTree largePineTree;

    public TreasureHunt treasureHunt;
    #endregion

    public void Update()
    {
        GatherScripts(); // gets "searching" scripts automatically

        GoldFound(); // 
    }


    private void GatherScripts()
    {
        if (pineTree == null)
        {
            treasureHunt = FindObjectOfType<TreasureHunt>();

            cherryBush = FindObjectOfType<CherryBush>();
            bush = FindObjectOfType<Bush>();
            largePineTree = FindObjectOfType<LargePineTree>();
            pineTree = FindObjectOfType<PineTree>();
        }
    }

    public void GoldFound()
    {
        if (treasureInBush == true && treasureGathered == true)
        {
            treasureHunt.allTreasureCount += 1;
            treasureCollected = true;
            treasureInBush = false;
        }

    }
}
