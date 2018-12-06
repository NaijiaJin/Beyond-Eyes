using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilguide : MonoBehaviour {

    // Use this for initialization
  //  public GameObject ui;
   public bool pause=false;
    Enemy enemyscript;
    public GameObject enemy;
	void Start () {
        enemyscript = enemy.GetComponent<Enemy>();
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void onmagicianclick()
    {
        enemyscript.ispause = !enemyscript.ispause;
     

    }
}
