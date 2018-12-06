using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showkillenemy : MonoBehaviour {

    public GameObject howtokill;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showoperation()
    {
        howtokill.SetActive(true);
    }

    public void hideoperation()
    {
        howtokill.SetActive(false);
    }
}
