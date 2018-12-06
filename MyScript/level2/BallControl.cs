using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    // Use this for initialization

    Rigidbody ballfly;
    GameObject target;
    public float movespeed=10.0f;
     GameObject evil;
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
        evil = GameObject.FindGameObjectWithTag("mage");
        ballfly=this.GetComponent<Rigidbody>();
       //InvokeRepeating("createball", 1, 5);
        Destroy(this.gameObject, 5.0f);
    }
	
	// Update is called once per frame
	void Update () {

        
		
	}
    void createball()
    {
        Debug.Log("累die");
        GameObject ball = Instantiate(this.gameObject, transform.position, Quaternion.identity);


    }
    private void FixedUpdate()
    {
       // Debug.Log(target.transform.position);
        transform.Translate(-1*transform.forward * movespeed * Time.deltaTime);
      //  transform.position = Vector3.MoveTowards(evil.transform.position, target.transform.position, movespeed * Time.deltaTime);
        //  ballfly.velocity = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
    }

   

}
