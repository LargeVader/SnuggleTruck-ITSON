using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTroca : MonoBehaviour {

	public AudioClip engineIdle, engineDriving;		// - Los sonidos 
	AudioSource source;								// - La bocina por la cual sonara el sonido

	void Awake() {
		source = GetComponent <AudioSource>();		// - Busca dentro del gameObject adjunto a este script, el componente AudioSource
		source.volume = 0.68f;
		source.clip = engineIdle;
		source.Play ();
	}

	void Update() {
		// - Si se presiona cualquier tecla izquierda o derecha, se reproduce el sonido de avanzando
		if (Input.GetAxisRaw ("Horizontal") != 0f) {
			if (source.clip == engineIdle) {
				source.clip = engineDriving;
				source.Play ();
			}
		} else {
			// - Se comprueba que el sonido de avanzando este sonando para cambiar una sola ves al sonido de Idle (reposo)
			if (source.clip == engineDriving) {
				source.clip = engineIdle;
				source.Play ();
			}
		}
	}
}
