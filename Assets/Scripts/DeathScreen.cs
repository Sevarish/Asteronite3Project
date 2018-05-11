    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour {

    public void Respawn()
    {
        Application.LoadLevel(1);
    }
}
