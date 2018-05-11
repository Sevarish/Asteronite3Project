using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstracoinManager : MonoBehaviour {
    public int Astracoins;
	// Use this for initialization
	void Start () {
        Astracoins = 0;
	}

    public void AddAstracoin(int astracoinAmount)
    {
        Astracoins += astracoinAmount;
    }
}
