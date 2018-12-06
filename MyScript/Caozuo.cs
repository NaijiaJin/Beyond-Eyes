using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caozuo : MonoBehaviour {


    public GameObject operation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showoperation()
    {
        operation.SetActive(true);
    }

    public void hideoperation()
    {
        operation.SetActive(false);
    }
}
