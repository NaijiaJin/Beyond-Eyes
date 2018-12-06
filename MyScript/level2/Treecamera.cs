using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treecamera : MonoBehaviour {

    // Use this for initialization

    public GameObject maincamera;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changecamera()
    {
        this.gameObject.SetActive(false);
        maincamera.SetActive(true);

    }
}
