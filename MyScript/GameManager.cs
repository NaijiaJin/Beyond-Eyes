using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameState
{
    Girl,
    Deer,
    Monster,
    Dead,
    won
};
public class GameManager : MonoBehaviour {


    public GameObject cloud;
    public GameObject flower1;
    public GameObject flower2;
    public GameState magic;

    public GameObject lava1;
    public GameObject lava2;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject stone4;
    public GameObject lava3;
    public GameObject lava4;

    public GameObject multicam;
    public GameObject endcam;

    public float speed = 10.0f;
    CharacterController controller;

    public Material deadsky;


    public GameObject M;
    public GameObject D;
    public GameObject G;

	// Use this for initialization
	void Start () {
        magic = GameState.Girl;
       
            cloud.SetActive(false);
            flower1.SetActive(false);
            flower2.SetActive(false);
            stone1.SetActive(true);
            stone2.SetActive(true);
            lava1.SetActive(false);
            lava2.SetActive(false);
            lava3.SetActive(false);
            lava4.SetActive(false);
            stone3.SetActive(true);
            stone4.SetActive(true);
        G.SetActive(true);
        M.SetActive(false);
        D.SetActive(false);

        controller = GetComponent<CharacterController>();
        
        
    }
	public void ChangeGameState()
    {
        if(magic==GameState.Girl)
        {
           
                cloud.SetActive(false);
            flower1.SetActive(false);
            flower2.SetActive(false);
            lava1.SetActive(false);
            lava2.SetActive(false);
            lava3.SetActive(false);
            lava4.SetActive(false);
            stone1.SetActive(true);
            stone2.SetActive(true);
            stone3.SetActive(true);
            stone4.SetActive(true);
            G.SetActive(true);
            M.SetActive(false);
            D.SetActive(false);
         

        }
        if(magic==GameState.Deer)
        {

       
            Debug.Log("gamestate deer");
            lava1.SetActive(false);
            lava2.SetActive(false);
           lava1.SetActive(true);
            lava2.SetActive(true);
            lava3.SetActive(true);
            lava4.SetActive(true);
            stone1.SetActive(false);
            stone2.SetActive(false);
            stone3.SetActive(false);
            stone4.SetActive(false);
            G.SetActive(false);
            M.SetActive(false);
            D.SetActive(true);

        }
        if(magic==GameState.Monster)
        {
          
                cloud.SetActive(false);
                flower1.SetActive(false);
                flower2.SetActive(false);
                Debug.Log("now monster");
                stone2.SetActive(false);
                stone1.SetActive(false);
                stone3.SetActive(false);
                stone4.SetActive(false);
                lava1.SetActive(true);
                lava2.SetActive(true);
                lava3.SetActive(true);
                lava4.SetActive(true);

            G.SetActive(false);
            M.SetActive(true);
            D.SetActive(false);


        }

        if(magic==GameState.Dead)
        {
         //   Instantiate(Boy, new Vector3(-0.79f, -0.36f, 0.47f), Quaternion.identity);
            Debug.Log("just dead");
           // RenderSettings.skybox = deadsky;

          //  Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(10, 10, 50), speed * Time.deltaTime);
        }

        if(magic==GameState.won)
        {
          //  multicam.SetActive(false);
           // endcam.SetActive(true);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
