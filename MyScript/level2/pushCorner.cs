using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushCorner : MonoBehaviour {


    public GameObject resetbtn;
    
	// Use this for initialization
	void Start () {
        resetbtn.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Corner")
        {
            resetbtn.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Corner")
        {
            resetbtn.SetActive(false);
        }
    }

}
