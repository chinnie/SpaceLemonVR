using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityDisengage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionExit(Collision collisionInfo)
    {
        Physics.gravity = Vector3.zero;
    }
}
