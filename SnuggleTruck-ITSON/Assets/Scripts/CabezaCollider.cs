using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;	// - Se necesita esta libreria para recargar la escena

//	# /Troca_body/Cabeza_Collider
// - Cuando la cabeza del jugador colisione con el piso, despues de 10 segundos se reinicia el nivel

public class CabezaCollider : MonoBehaviour {

	// - Cuando se colisione con el piso, recarga la escena
	void OnCollisionEnter2D(Collision2D other) {
		if (other.collider.CompareTag ("Piso"))
			StartCoroutine (RestartScene ());
	}

	// - Espera 8 segundos antes de recargar la escena acual.
	IEnumerator RestartScene() {
		yield return new WaitForSeconds (5f);
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}
}
