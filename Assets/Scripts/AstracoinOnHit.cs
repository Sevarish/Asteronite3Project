using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstracoinOnHit : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        GameObject.Find("Player").GetComponent<AstracoinManager>().AddAstracoin(6);
        Destroy(this.gameObject);

    }
}
