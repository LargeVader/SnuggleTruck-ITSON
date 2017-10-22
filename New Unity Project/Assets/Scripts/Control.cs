using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    public float speed = 1500f;
    public float rotationSpeed = 15f;
    
    float movement;
    float rotation;

    public WheelJoint2D llantaTrasera;
    public WheelJoint2D llantaDelantera;
    public Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate() {
//  //      movement = -Input.GetAxisRaw("Horizontal") * speed;
//  //      rotation = Input.GetAxisRaw("Vertical");

        if (movement == 0f)
        {
            llantaTrasera.useMotor = false;
            llantaDelantera.useMotor = false;
        } else {
            llantaDelantera.useMotor = true;
            llantaTrasera.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 800f };
            llantaTrasera.motor = motor;
            llantaDelantera.motor = motor;
        }
        rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
    }

    public void BotonDerecha()
    {
        movement = -1 * speed;
    }

    public void BotonIzquierda()
    {
        movement = 1 * speed;
    }

    public void ButtonReleased()
    {
        movement = 0f;
    }
}
