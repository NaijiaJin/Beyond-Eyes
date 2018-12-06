using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoyInteraction : MonoBehaviour {

    // Use this for initialization
    public GameObject meetflower;
    public GameObject flowercount;
    public GameObject flowerimage;
    public GameObject jumptext;
    public GameObject wandspace;
    public GameObject firstdeer;
    public GameObject firstmonster;
    public GameObject switcheyes;


    public GameObject Chooseorbs;
    private bool showorbs = false;
    Text flowertext;
    public BoyMoveTest BoyMoveText;
    public MonsterClick monsterclick;
    public GameObject monsterclickobject;

    //火焰声音靠近播放
    public GameObject monsterfire;

    Animator anim_;

    private int count =0;

    public AudioClip collectflower;
    public AudioClip boxcrush;
    public bool ispushing = false;

    GameManager manager;

    public AudioSource pushsource;

    CharacterController controller;

    public GameObject movestone;

    public GameObject firework;

    public AudioClip win;

    private AudioSource original;
    public GameObject gamemanager;

    public AudioClip injuresound;
    public GameObject fireworkpoint;

    public GameObject flowerparticle;
    public GameObject boxcrushparticle;

    public Button btngirl;
    public Button btnMonster;
    public Button btnDeer;

    public AudioClip textguide;
    public GameObject terminalparticle;


    public GameObject winstar;
    public GameObject winstarpoint;

    public GameObject nextlevelbtn;

    RectTransform grilbtnrect;
    RectTransform deerbtnrect;
    RectTransform monsterbtnrect;

    void Awake()
    {
        original = GetComponent<AudioSource>();
    }
  
	void Start () {
       flowertext= flowercount.GetComponent<Text>();
        flowertext.text = "0";
        Chooseorbs.SetActive(false);
        BoyMoveText = GetComponent<BoyMoveTest>();
        anim_ = GetComponent<Animator>();
        monsterclick = monsterclickobject.GetComponent<MonsterClick>();
        manager = gamemanager.GetComponent<GameManager>();

        
        pushsource = gameObject.AddComponent<AudioSource>();
        controller = GetComponent<CharacterController>();
        terminalparticle.SetActive(false);
        nextlevelbtn.SetActive(false);
        grilbtnrect = btngirl.GetComponent<RectTransform>();
        deerbtnrect = btnDeer.GetComponent<RectTransform>();
        monsterbtnrect = btnMonster.GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            showorbs = !showorbs;
            Chooseorbs.SetActive(showorbs);


            if (showorbs == true)
            {
                BoyMoveText.enabled = false;
            }
            else if (showorbs == false)
            { BoyMoveText.enabled = true; }


            if (manager.magic == GameState.Girl)
            {
                //grilbtnrect.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                //deerbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //monsterbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                
                btngirl.Select();
                btngirl.OnSelect(null);
            }
            else if (manager.magic == GameState.Deer)
            {
                //deerbtnrect.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                //grilbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //monsterbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                btnDeer.Select();
                btnDeer.OnSelect(null);
            }
            else if (manager.magic == GameState.Monster)
            {
                //monsterbtnrect.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                //grilbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //deerbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                btnMonster.Select();
                btnMonster.OnSelect(null);
            }
            else
            {
               
                btngirl.Select();
                btngirl.OnSelect(null);



            }
            if (Input.GetKeyDown(KeyCode.Q) && (showorbs == true))
            {
                Debug.Log("qqqq");


            }

            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }


        }
    }


        void OnTriggerEnter(Collider other)
    {
            if (other.tag == "meetflower")
            {
                Debug.Log("meetflower");
                //  
                meetflower.SetActive(true);
            AudioSource.PlayClipAtPoint(textguide, transform.position);


            }
            if (other.tag == "firstjump")
            {
                Debug.Log("jump");
                jumptext.SetActive(true);
            wandspace.SetActive(true);
            AudioSource.PlayClipAtPoint(textguide, transform.position);


        }
            if (other.tag == "firstDeer")
            {
                Debug.Log("jump");
                firstdeer.SetActive(true);
            switcheyes.SetActive(true);
            AudioSource.PlayClipAtPoint(textguide, transform.position);


        }
            if (other.tag == "firstmonster")
            {
                Debug.Log("firstmonster");
                firstmonster.SetActive(true);
            AudioSource.PlayClipAtPoint(textguide, transform.position);


        }

            if (other.tag == "firstMonDisappear")
            {
                firstmonster.SetActive(false);
            }
            if (other.tag == "flower")
            {
                GameObject clone2 = Instantiate(flowerparticle, other.transform.position, Quaternion.identity);
                clone2.transform.Rotate(-90, 0, 0);
                Destroy(clone2, 2.0f);
                flowerimage.SetActive(true);
                flowercount.SetActive(true);
                flowerimage.SetActive(true);
                AudioSource.PlayClipAtPoint(collectflower, Vector3.zero);


                count++;
                flowertext.text = count.ToString();
                Debug.Log("so beautiful");
                other.gameObject.SetActive(false)
    ; }
            if (other.tag == "moveparent")
            {
                movestone.transform.DetachChildren();
                Debug.Log("liiiiiiii");
            }


            if (other.tag == "finalflower")
            {
                manager.magic = GameState.won;
                manager.ChangeGameState();
                Instantiate(firework,fireworkpoint.transform.position, Quaternion.identity);
            winstar.SetActive(true);
            nextlevelbtn.SetActive(true);
                other.gameObject.SetActive(false);
                original.Stop();
                AudioSource.PlayClipAtPoint(win, transform.position);
                terminalparticle.SetActive(false);
                anim_.SetBool("iswin", true);
                Invoke("setwinfalse", 1.0f);


            }

            if(other.tag=="terminalshow")
            {
                terminalparticle.SetActive(true);
            }
            if (other.tag == "Dead")
            {
                Debug.Log("deadddddddddddddddddddddd");
                //  Destroy(this.gameObject);
                manager.magic = GameState.Dead;
                manager.ChangeGameState();
                //  controller.enabled = false;
                AudioSource.PlayClipAtPoint(injuresound, transform.position);
                transform.position = new Vector3(-1.0f, 0.0f, 0.671f);



            }

            if(other.tag=="Dead2")
            {
                AudioSource.PlayClipAtPoint(injuresound, transform.position);
                Debug.Log("dead in zone2");
                transform.position = new Vector3(-1.62f, 1.0f, 18.8f);

            //transform.parent = null;
            }   

            if(other.tag=="reborn")
        {
            Debug.Log("reborn");
            transform.parent = null;
           
        }
            
            if(other.tag=="monsterfire")
        {
            monsterfire.GetComponent<AudioSource>().Play();

        }         


        }
    

    void setwinfalse()
    {
        anim_.SetBool("iswin", false);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "meetflower")
        {
            Debug.Log("meetflower");
            meetflower.SetActive(false);

        }
        if (other.tag == "firstjump")
        {
            Debug.Log("jump");
            jumptext.SetActive(false);
            wandspace.SetActive(false);


        }
        if (other.tag == "firstDeer")
        {
            Debug.Log("jump");
            firstdeer.SetActive(false);
            switcheyes.SetActive(false);


        }

        if(other.tag=="monsterfire")
        {
            monsterfire.GetComponent<AudioSource>().Stop();
        }
        //if (other.tag == "firstmonster")
        //{
        //    Debug.Log("firstmonster");
        //    firstmonster.SetActive(false);


        //}
    }


    //void OnCollisionEnter(Collision other)
    //{
    //    if(other.gameObject.tag=="cloud")
    //    {
    //        other.transform.Translate(0, 0, 1);
    //        Debug.Log("meet cloud");
    //    }
    //    if(other.gameObject.tag=="giantbox")
    //    {
           
            

    //    }
    //}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if((hit.collider.tag=="giantbox")&&(manager.magic==GameState.Monster))
        {
            pushsource.clip = boxcrush;
            hit.gameObject.AddComponent<Rigidbody>();
            Rigidbody body = hit.collider.attachedRigidbody;
            //   body.mass = 10000;
            // body.velocity = new Vector3(1, 0, 1) * 30.0f;
            GameObject clone3= Instantiate(boxcrushparticle, hit.transform.position, Quaternion.identity);
            Destroy(clone3, 1.0f);
            Debug.Log("skr");
            pushsource.Play();
            ispushing = true;
        }
        else
        {
            ispushing = false;
        }




        if ((hit.collider.tag == "Movestone") && (controller.isGrounded == true))
        {
            this.transform.parent = hit.transform;
        }

    }





    public void Girlonhover()
    {
        grilbtnrect.localScale = new Vector3(1.5f, 1.5f, 1.5f);
       deerbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
       monsterbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
    public void onhoverexit()
    {
        grilbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        deerbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        monsterbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void Deeronhover()
    {
        grilbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        deerbtnrect.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        monsterbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void Monsteronhover()
    {
        grilbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        deerbtnrect.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        monsterbtnrect.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    
}
