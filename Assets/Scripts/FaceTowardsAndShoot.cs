using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTowardsAndShoot : MonoBehaviour {

    // The target marker.
    public Transform target;

    public GameObject Bullet_Emitter;


    public GameObject Bullet;


    public float Bullet_Forward_Force;

    bool shotActive = true;
    int shootCount = 0;

    void Update()
    {
        int speed = 10000;
        var q = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, speed * Time.deltaTime);
        
        if (shotActive == true && GameObject.Find("Player").GetComponent<TrackPlayerLocation>().player.transform.position.x > transform.position.x - 700 && GameObject.Find("Player").GetComponent<TrackPlayerLocation>().player.transform.position.x < target.position.x + 7000 && GameObject.Find("Player").GetComponent<TrackPlayerLocation>().player.transform.position.z > target.position.z - 700 && GameObject.Find("Player").GetComponent<TrackPlayerLocation>().player.transform.position.z < target.position.z + 700)
        {
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
            Temporary_Bullet_Handler.transform.Rotate(Vector3.right * 90);
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);
            Destroy(Temporary_Bullet_Handler, 4);
            shotActive = false;
        }

        if (shotActive == false)
        {
            if (shootCount < 40)
            {
                shootCount++;
            }
            else
            {
                shotActive = true;
                shootCount = 0;
            }
        }
    }
}
