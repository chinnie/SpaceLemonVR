using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityDisengage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    // Update is called once per frame
    void Update()
    {

        if (Physics.gravity.y > 0)
        {
            Physics.gravity = Vector3.zero;
        }

    }

    void OnCollisionExit(Collision collisionInfo)
    {
        Physics.gravity = new Vector3(0, 50, 0);


    }
}
