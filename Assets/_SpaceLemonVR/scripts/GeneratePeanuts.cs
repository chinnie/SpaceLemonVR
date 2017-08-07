using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePeanuts : MonoBehaviour {
    [SerializeField] private GameObject peanuts;
    [SerializeField] private GameObject gift;

	// Use this for initialization
	void Start ()
	{
	    Mesh boxMesh = gameObject.GetComponent<MeshFilter>().mesh;
	    Bounds bounds = boxMesh.bounds;

	    float minX = gameObject.transform.position.x - gameObject.transform.localScale.x * bounds.size.x * 0.5f;
        float minY = gameObject.transform.position.y - gameObject.transform.localScale.y * bounds.size.y * 0.5f;
        float minZ = gameObject.transform.position.z - gameObject.transform.localScale.z * bounds.size.z * 0.5f;


        for (int i = 0; i < 150; i++)
	    {   
            Vector3 position = new Vector3(Random.Range (minX, -minX), Random.Range(minY, -minY), Random.Range(minZ, -minZ));
	        GameObject.Instantiate(peanuts, position, Quaternion.identity);
	    }

	    GameObject.Instantiate(gift, transform.parent.position, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
