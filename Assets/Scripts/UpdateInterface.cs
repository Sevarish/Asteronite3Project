using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInterface : MonoBehaviour {
    public Text XYZText;
    public Text FiringText;
    public Text HealthBarText;
    public Text ForceText;
    public Text AstracoinsText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      if (GameObject.Find("Player").GetComponent<ShootGun>().isFiring == true)
        {
            FiringText.text = "Firing: True";
        }
      else
        {
            FiringText.text = "Firing: False";
        }

        XYZText.text = "X: " + GameObject.Find("Player").GetComponent<TrackPlayerLocation>().player.transform.position.x + "\n Y: " + GameObject.Find("Player").GetComponent<TrackPlayerLocation>().player.transform.position.y + "\n Z: " + GameObject.Find("Player").GetComponent<TrackPlayerLocation>().player.transform.position.z;
        HealthBarText.text = "HP:    " + GameObject.Find("Player").GetComponent<Health>().CurrentHealt + "       /        " + GameObject.Find("Player").GetComponent<Health>().MaxHealt;
        ForceText.text = "Force: " + GameObject.Find("Player").GetComponent<move>().throttle;
        AstracoinsText.text = "Astracoins: " + GameObject.Find("Player").GetComponent<AstracoinManager>().Astracoins;

    }
}
