using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlClick : MonoBehaviour {

    public Material girlsky;
    // Use this for initialization
    GameManager manager;
    public GameObject boymanager;
    public GameObject boy;
    public AudioClip peacefulgirl;
    public AudioClip girlvoice;
    public GameObject girlparticle;
	void Start () {
        manager = boymanager.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {

		
	}

   public void OnClickGirl()
    {
        AudioSource.PlayClipAtPoint(girlvoice, transform.position);
        RenderSettings.skybox = girlsky;

        GameObject clone = Instantiate(girlparticle, boy.transform.position, Quaternion.Euler(90, 0, 0));
        clone.transform.Translate(0, 0, -0.3f);
        Destroy(clone, 2.0f);

        AudioSource.PlayClipAtPoint(peacefulgirl, transform.position);
        manager.magic = GameState.Girl;
        manager.ChangeGameState();

    }
}
