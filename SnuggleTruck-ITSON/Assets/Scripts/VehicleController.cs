using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// # /Troca_body/

/// <summary>
/// Controla el movimiento de la troca en el juego. La troca avanza hacia adeltante o hacia atras con las flechas del teclado.
/// </summary>

public class VehicleController : MonoBehaviour {

	// - Arrastra y suelta los WheelJoin2D aqui en el Inspector
	public WheelJoint2D llanta_trasera, llanta_delantera;

	[Range(0.0f, 1500.0f)]			// <- Range sirve para anexar un "slider" donde se seleccione el valor de speed
	public float speed = 800f;				// - La velocidad de la troca
	[Range(0.0f, 15f)]				// <- Range sirve para anexar un "slider" donde se seleccione el valor de rotationSpeed
	public float rotationSpeed = 10f;

	private float movement, rotation;
	private Rigidbody2D rb;

	// - Awake se llama al cargar la escena del juego.
	void Awake() {
		// - Se obtiene el rigidbody que este anexado a este GameObject al cargar la escena.
		rb = GetComponent <Rigidbody2D>();
	}

	// - Update() esta funcion es llamada cada frame por frame.
	// - Cuando el usuario presione las flechas del teclado o la teclas 'A', 'S', 'W', 'D' del teclado.
	void Update() {
		// - Si presiona a la izquierda, movement tendra el valor de -1.
		//	 Si presiona la derecha, movement tendra el valor de +1.
		//   Si el usuario no presiona ninguna tecla, GetAxisRaw regresa 0 (cero).
		movement = -Input.GetAxisRaw ("Horizontal") * speed;
		rotation = Input.GetAxisRaw ("Vertical");
	}

	// - FixedUpdate() se ejectua todo el tiempo de manera asincr	ona con la funcion Update y aqui se pone el codigo que utilice las fisicas de Unity
	void FixedUpdate() {
		//  - Si ninguna tecla es presionada
		if (movement == 0f) {
			// - Se apagan los motores de la troca
			llanta_trasera.useMotor = false;
			llanta_delantera.useMotor = false;		
		} else {
			// - Se encienden los motores de la troca
			llanta_trasera.useMotor = true;
			llanta_delantera.useMotor = true;

			// - Se crea una instancia de la Clase JoinMotor2D pasandole la variable "movement" como motorSpeed (velocidad del motor)
			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000f };

			// - Se establece la instancia a ambos motores de la troca
			llanta_trasera.motor = motor;
			llanta_delantera.motor = motor;
		}
	}
}