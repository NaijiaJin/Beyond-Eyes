using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour {

    public GameObject cam1;
    public GameObject cam2;
   
	// Use this for initialization

    void start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

	void SwitchCamera()
    {
        Debug.Log("what the hell");
        cam1.SetActive(false);
        cam2.SetActive(true);


    }

  
}
