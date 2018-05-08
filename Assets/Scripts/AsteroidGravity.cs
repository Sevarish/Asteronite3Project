using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGravity : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.down * 0F;
        transform.Rotate(Vector3.left * 1);
        transform.Rotate(Vector3.down * 1);
    }
}
