using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface ISearchInterface
{

    protected OnTriggerEnter2D InSearchArea(Collider2D collision); // Make a bool for "WithinSearchArea" and set it true here

    protected OnTriggerExit2D OutsideSearchArea(Collider2D collision); // Make "WithinSearchArea" false here

    protected void StartSearching(); // Place any extra code here (Including animations)

    

}
