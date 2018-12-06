using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavafire : MonoBehaviour {

    // Use this for initialization
    public GameObject bigfire;
    public AudioClip burningdown;
    public GameObject magician;
    public GameObject goodjiazi;
    public GameObject badjiazi;
    public AudioClip enemydie;

    public GameObject treewall1;
    public GameObject treewall2;
    public GameObject fogcome;
    public GameObject attackarea;
    public GameObject boy;
    GameObject findjiao;

    public GameObject afterkilltext;
    public AudioClip clash;
    public GameObject earthwall;

    public GameObject pushstone;

    public GameObject arrow;
 //   public GameObject arrow2;
	void Start () {
        bigfire.SetActive(false);
        afterkilltext.SetActive(false);
        findjiao = GameObject.FindGameObjectWithTag("jiao");
        earthwall.SetActive(false);

    //    arrow2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
     //   Debug.Log(findjiao.name);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="killpoint")
        {
            bigfire.SetActive(true);
            AudioSource.PlayClipAtPoint(burningdown, boy.transform.position);
            AudioSource.PlayClipAtPoint(enemydie, boy.transform.position);
            Destroy(bigfire, 5.0f);
            goodjiazi.SetActive(false);
            badjiazi.SetActive(true);
            magician.SetActive(false);

            treewall1.SetActive(false);
            treewall2.SetActive(false);
            fogcome.SetActive(false);
            attackarea.SetActive(false);
            AudioSource.PlayClipAtPoint(clash, boy.transform.position);

            afterkilltext.SetActive(true);

            Destroy(afterkilltext, 8.0f);
            earthwall.SetActive(true);
            Destroy(earthwall, 5.0f);
            pushstone.SetActive(false);
            arrow.SetActive(false);

            this.GetComponent<BoxCollider>().enabled=false;
          //  Destroy(arrow);


          //  arrow2.SetActive(true);
        }
    }
}
