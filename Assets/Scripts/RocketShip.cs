using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShip : MonoBehaviour
{
    private AudioSource engineSound;
    private Rigidbody rocketRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        this.rocketRigidBody = GetComponent<Rigidbody>();
        this.engineSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.rocketRigidBody.AddRelativeForce(Vector3.up);
            if (!this.engineSound.isPlaying)
            {
                this.engineSound.Play();
            }
        } else
        {
            this.engineSound.Stop();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        } 
        else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(Vector3.back);

        }
    }
}
