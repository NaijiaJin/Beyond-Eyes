using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDisappear : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Dead2")
        {
            Destroy(this.gameObject);
            Debug.Log("BOX DISAPPERA");
        }
    }

}
