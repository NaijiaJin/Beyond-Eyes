using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterClick : MonoBehaviour {

    // Use this for initialization
 //   public bool empowered = false;
    public AudioClip monstervoice;
    public AudioClip demonmagic;
    public Material monstersky;
    public GameObject boymanager;
    public GameObject boy;
    public GameObject monstershadow;
    Animator boyanim;

    public GameObject monsterwings;
    GameManager gamemanager;
	void Start () {
      
        gamemanager = boymanager.GetComponent<GameManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClickMonster()
    {
        
        Debug.Log("boy empowered");
        GameObject clone = Instantiate(monstershadow, boy.transform.position, Quaternion.Euler(90,0,0));
       clone.transform.Translate(0, 0, -0.3f);

        Destroy(clone, 2.0f);
        monsterwings.SetActive(true);
        Invoke("wingD", 2.0f);
        AudioSource.PlayClipAtPoint(monstervoice, transform.position);
        AudioSource.PlayClipAtPoint(demonmagic, transform.position);
        RenderSettings.skybox = monstersky;
        gamemanager.magic = GameState.Monster;
        gamemanager.ChangeGameState();
        //boyanim.SetBool("ismonster",true);


    }

    void wingD()
    {
        monsterwings.SetActive(false);
    }
}
