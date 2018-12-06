using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBox : MonoBehaviour {

    // Use this for initialization
    public GameObject pushbox;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnclickReset()
    {
        pushbox.transform.position = new Vector3(-1.252f, -0.63f, 3f);
    }
}
