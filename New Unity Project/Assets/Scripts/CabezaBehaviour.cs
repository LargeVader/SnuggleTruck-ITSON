using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CabezaBehaviour : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider.CompareTag("Piso"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
