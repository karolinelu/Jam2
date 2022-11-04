using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    // Start is called before the first frame update
  public int NumberOfFormulas { get; private set;}

  public void FormulaCollected(){
    NumberOfFormulas++;
  }

}
