using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretFormulas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
            print("Hello?");
            Collecting playerInventory = other.GetComponent<Collecting>();

            if(playerInventory != null){
                    playerInventory.FormulaCollected();
                    gameObject.SetActive(false);
            }
    }
   
  
}
