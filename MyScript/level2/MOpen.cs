using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOpen : MonoBehaviour {

    // Use this for initialization
    public GameObject disapperparticle;
    public GameObject particlepoint;
    public AudioClip boom;
    public GameObject doorm;
    public GameObject doorl;
    public GameObject doorr;
  public  AudioClip dooropen;
    public GameObject middleopenbig;

    public GameObject earthparticle;

    Collider cdm;
    Collider cdl;
    Collider cdr;
    Animation dm;
    Animation dl;
    Animation dr;
	void Start () {
        dm = doorm.GetComponent<Animation>();
        dl = doorl.GetComponent<Animation>();
        dr = doorr.GetComponent<Animation>();
        cdm = doorm.GetComponent<MeshCollider>();
        cdl = doorl.GetComponent<MeshCollider>();
        cdr = doorr.GetComponent<MeshCollider>();
        earthparticle.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Middle")
        {
            Debug.Log("well done");
            Instantiate(disapperparticle, particlepoint.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(boom, transform.position);
            earthparticle.SetActive(true);
            dm.Play();
            dl.Play();
            dr.Play();
            cdm.isTrigger = true;
            cdl.isTrigger = true;
            cdr.isTrigger = true;
            AudioSource.PlayClipAtPoint(dooropen, transform.position);
            middleopenbig.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
