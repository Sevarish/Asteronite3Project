using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    Rigidbody m_Rigidbody;
    float m_Speed;            
	// Use this for initialization
	void Start () {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
    }
    public float acceleration = 1.5F;
	// Update is called once per frame
	void Update () {
        float xInput = Input.GetAxisRaw("Horizontal");
        print(xInput);
        float inputSpeed = xInput * 1F;
        transform.Rotate(Vector3.up * inputSpeed);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * -m_Speed;
        }


    }
}
