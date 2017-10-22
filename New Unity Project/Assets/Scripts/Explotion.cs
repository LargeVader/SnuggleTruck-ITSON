using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour {

    public GameObject chile;

    void Awake(){
        chile.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
            StartCoroutine(ExplotionDelay());
    }

    IEnumerator ExplotionDelay() {
        yield return new WaitForSeconds(2f);
        chile.SetActive(true);
        Destroy(chile, 1f);
    }
}
