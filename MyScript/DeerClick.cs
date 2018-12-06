using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerClick : MonoBehaviour {

    public GameObject cloud1;
    public AudioClip holydeer;
    // Use this for initialization

    public Material deersky;
    public GameObject lamegrass1;
    public GameObject lamegrass2;
    public GameObject flower1;
    public GameObject flower2;

    GameManager manager;
    public GameObject boymanager;
    public GameObject boy;

    public GameObject deerparticle;
    public GameObject deerimage;
    
    void Start () {
        cloud1.SetActive(false);
        flower1.SetActive(false);
        flower2.SetActive(false);

        manager = boymanager.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnclickDeer()
    {
        Debug.Log("click deer pattern");
        cloud1.SetActive(true);

        deerimage.SetActive(true);
        Invoke("deerd", 2.0f);
        GameObject clone = Instantiate(deerparticle, boy.transform.position, Quaternion.Euler(90, 0, 0));
        clone.transform.Translate(0, 0, -0.3f);
        Destroy(clone, 2.0f);
        AudioSource.PlayClipAtPoint(holydeer, transform.position);
        RenderSettings.skybox = deersky;
        lamegrass1.SetActive(false);
        lamegrass2.SetActive(false);
        flower1.SetActive(true);
        flower2.SetActive(true);

        manager.magic = GameState.Deer;
        manager.ChangeGameState();

    }

    void deerd()
    {
        deerimage.SetActive(false);
    }
}
