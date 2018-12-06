using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerClick2 : MonoBehaviour {


    public AudioClip holydeer;
    // Use this for initialization

    public Material deersky;

    public GameObject boymanager;
    public GameObject boy;


    GameManagerSec manager;
    public GameObject deerparticle;
    public GameObject deerimage;
    Interaction interaction;
    // Use this for initialization
    void Start () {

        manager = boymanager.GetComponent<GameManagerSec>();
        interaction = boy.GetComponent<Interaction>();

    }
	
	// Update is called once per frame
	void Update () {
       

    }

    public void OnClickDeer2()
    {
        if (interaction.israin == false)
        {
            Debug.Log("click deer pattern");
            manager.magic = GameState2.Deer;
            manager.ChangeGameState();

            deerimage.SetActive(true);
            Invoke("deerd", 2.0f);
            GameObject clone = Instantiate(deerparticle, boy.transform.position, Quaternion.Euler(90, 0, 0));
            clone.transform.Translate(0, 0, -0.3f);
            Destroy(clone, 2.0f);
            AudioSource.PlayClipAtPoint(holydeer, transform.position);
            RenderSettings.skybox = deersky;
        }
        else
        {

            manager.magic = GameState2.Deerrain;
            manager.ChangeGameState();
            Debug.Log("要下雨啦");
            deerimage.SetActive(true);
            Invoke("deerd", 2.0f);
            GameObject clone = Instantiate(deerparticle, boy.transform.position, Quaternion.Euler(90, 0, 0));
            clone.transform.Translate(0, 0, -0.3f);
            Destroy(clone, 2.0f);
            AudioSource.PlayClipAtPoint(holydeer, transform.position);
            RenderSettings.skybox = deersky;
        }

        

      
    }
    void deerd()
    {
        deerimage.SetActive(false);
    }

}



