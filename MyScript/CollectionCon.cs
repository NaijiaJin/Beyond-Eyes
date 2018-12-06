using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionCon : MonoBehaviour {

    // Use this for initialization
    public float speed=2.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.down * speed, Space.World);
		
	}
}
