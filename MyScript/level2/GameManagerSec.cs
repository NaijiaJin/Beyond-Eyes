using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState2
{
    Girl,
    Deer,
    Deerrain,
    Monster,
    Dead,
    won
};
public class GameManagerSec : MonoBehaviour {


    public GameState2 magic;
    public GameObject pushbox;
    public GameObject cloud;

    public GameObject lava1;
    public GameObject lava2;
    public GameObject lava3;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;

    public GameObject lava4;
    public GameObject lava5;
    public GameObject lava6;
    public GameObject stone4;
    public GameObject stone5;
    public GameObject stone6;

    public GameObject m;
    public GameObject d;
    public GameObject g;

    public GameObject raincloud;
    public GameObject pushstone;
    public GameObject pushlava;

    // Use this for initialization
    void Start () {
        magic = GameState2.Girl;
        cloud.SetActive(false);
        lava1.SetActive(false);
        lava2.SetActive(false);
        lava3.SetActive(false);
        lava4.SetActive(false);
        lava5.SetActive(false);
        lava6.SetActive(false);
        g.SetActive(true);
        m.SetActive(false);
        d.SetActive(false);
        raincloud.SetActive(false);
        pushlava.SetActive(false);
    }

    public void ChangeGameState()
    {
        if (magic == GameState2.Girl)
        {
            Debug.Log("i am a girl now");
           
            cloud.SetActive(false);
            Debug.Log("lava go away");
            lava1.SetActive(false);
            lava2.SetActive(false);
            lava3.SetActive(false);
            lava4.SetActive(false);
            lava5.SetActive(false);
            lava6.SetActive(false);

            stone1.SetActive(true);
            stone2.SetActive(true);
            stone3.SetActive(true);
            stone4.SetActive(true);
            stone5.SetActive(true);
            stone6.SetActive(true);
            if (pushbox.GetComponent<Rigidbody>())
            { pushbox.GetComponent<Rigidbody>().isKinematic = true; }

            g.SetActive(true);
            m.SetActive(false);
            d.SetActive(false);

            raincloud.SetActive(false);
            pushlava.SetActive(false);
            pushstone.SetActive(true);

        }
        if (magic == GameState2.Deer)
        {
            cloud.SetActive(true);
            lava1.SetActive(true);
            lava2.SetActive(true);
            lava3.SetActive(true);
            lava4.SetActive(true);
            lava5.SetActive(true);
            lava6.SetActive(true);

            stone1.SetActive(false);
            stone2.SetActive(false);
            stone3.SetActive(false);
            stone4.SetActive(false);
            stone5.SetActive(false);
            stone6.SetActive(false);
            Debug.Log("i am a deer now");
            if (pushbox.GetComponent<Rigidbody>())
            { pushbox.GetComponent<Rigidbody>().isKinematic = true; }

            g.SetActive(false);
            m.SetActive(false);
            d.SetActive(true);

            raincloud.SetActive(false);
            pushlava.SetActive(true);
            pushstone.SetActive(false);

        }
        if (magic == GameState2.Monster)
        {
            lava1.SetActive(true);
            lava2.SetActive(true);
            lava3.SetActive(true);
            lava4.SetActive(true);
            lava5.SetActive(true);
            lava6.SetActive(true);

            stone1.SetActive(false);
            stone2.SetActive(false);
            stone3.SetActive(false);
            stone4.SetActive(false);
            stone5.SetActive(false);
            stone6.SetActive(false);
            Debug.Log("i am a monster now");
            cloud.SetActive(false);

            g.SetActive(false);
            m.SetActive(true);
            d.SetActive(false);

            raincloud.SetActive(false);
            pushlava.SetActive(true);
            pushstone.SetActive(false);



        }

        if (magic == GameState2.Dead)
        {
            //   Instantiate(Boy, new Vector3(-0.79f, -0.36f, 0.47f), Quaternion.identity);
            Debug.Log("just dead");
            // RenderSettings.skybox = deadsky;

            //  Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(10, 10, 50), speed * Time.deltaTime);
        }

        if (magic == GameState2.won)
        {
            //  multicam.SetActive(false);
            // endcam.SetActive(true);
        }

        if(magic==GameState2.Deerrain)
        {
            g.SetActive(false);
            m.SetActive(false);
            d.SetActive(true);

            raincloud.SetActive(true);
            


        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
