using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    float distance;
    void Start(){
        distance = transform.position.z;
    }

	void Update () {
       transform.position = new Vector3(target.position.x, 
                                        target.position.y,
                                        distance );
	}
}
