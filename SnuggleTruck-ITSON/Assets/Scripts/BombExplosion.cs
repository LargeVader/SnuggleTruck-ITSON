using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// # /Bomb_mina
// - Este script activa la explosion de la bomba. Cuando el Jugador colisione con este gameObject, despues de x segundos explotara la bomba.

public class BombExplosion : MonoBehaviour {

	// - La explosion que contiene el PointEffector2D
	public GameObject explosion_TriggerCollider;

	// - Cuando se cargue la escena desactivamos el gameObject
	void Awake() {
		explosion_TriggerCollider.SetActive (false);
	}

	// - Unicamente cuando el colisionador tenga el Tag "Player", se activa la explosion
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player")) {
			StartCoroutine (ActivaExplosion ());
		}
	}

	// - Se activa la explosion despues de 2 segundos, luego, despues de 1 segundo se auto destruye 
	IEnumerator ActivaExplosion() {
		yield return new WaitForSeconds (2f);
		explosion_TriggerCollider.SetActive (true);
		Destroy (gameObject, 1f);
	}
}