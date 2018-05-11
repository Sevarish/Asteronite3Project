using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour
{

    public GameObject Bullet_Emitter;


    public GameObject Bullet;


    public float Bullet_Forward_Force;
    public bool isFiring = false;
    int isFireCount = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKey(KeyCode.Space) && isFireCount < 5) 
        {
            
            isFiring = true;
            
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            //Basic Clean Up, set the Bullets to self destruct after 4 Second.
            Destroy(Temporary_Bullet_Handler, 4);
        }
        else if (isFireCount > 20)
        {
            isFiring = false;
            isFireCount = 0;
        }
        else
        {
            isFiring = false;
        }
        isFireCount++;
        
    }
}