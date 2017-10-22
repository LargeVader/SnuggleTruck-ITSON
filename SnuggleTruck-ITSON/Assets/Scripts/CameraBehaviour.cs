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
		newPositon = troca.position;
		newPositon.z = distanciaInicial;

		transform.position = newPositon;
	}
}
