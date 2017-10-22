using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// # /MainCamera
// - La camara sigue al jugador 

public class CameraBehaviour : MonoBehaviour {

	public Transform troca;

	private Vector3 newPositon;
	private float distanciaInicial;

	// - Obtiene la distancia entre la camara y la troca
	void Awake() {
		distanciaInicial = transform.position.z;
	}

	// - La nueva posicion de la camara sera la de la troca conservando la distancia inicial que tenia cuando se carga la escena.
	void FixedUpdate() {
		newPositon = troca.position;		// - Se obtiene la posicion de la troca
		newPositon.z = distanciaInicial;	// - Se establece la distancia que se tenia entre la camara y la troca al inicio del juego
		newPositon.y = 1f;	// - Se aumenta ligeramente la posicion de la camara sobre el eje 'Y'

		transform.position = newPositon;	// - Se pasa la nueva posicion a la camara
	}
}
