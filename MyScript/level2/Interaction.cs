using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VolumetricFogAndMist;

public class Interaction : MonoBehaviour {

    public GameObject Chooseorbs;
    private bool showorbs = false;
    BoyMove2 BoyMove;
    GameManagerSec manager;
    public GameObject gamemanager;
    public Button btngirl;
    public Button btnMonster;
    public Button btnDeer;
    public GameObject flowercount;
    public GameObject flowerimage;
    Text flowertext;

    AudioSource pushsource;
    public AudioClip pushbox;
    public AudioClip deadsound;

    public GameObject castle;
    public GameObject fireparticle;
    AudioSource firesound;

    public GameObject enemy;
    Animator enemyanim;
    public bool meetenemy=false;

    public AudioClip enemylaugh;
    Enemy enemyscript;

    public AudioClip feixu;
    public AudioClip bird;
    public GameObject maincamera;
    Transform cameraT;

    DemoWalk mist;
    float smooth = 5.0f;

    public bool israin=false;
    public bool isjiao1 = false;
    public bool isjiao2 = false;
    public bool isjiao3 = false;
    public GameObject rainparticle1;
    public GameObject rainparticle2;
    public GameObject rainparticle3;



    int keyframe1 = 0;
    bool keyframeover1 = false;
    int keyframe2 = 0;
    bool keyframeover2 = false;
    int keyframe3 = 0;
    bool keyframeover3 = false;

    public Slider jiao1;
    public Slider jiao2;
    public Slider jiao3;


    public GameObject jiao1desert;
    public GameObject jiao1grass;
    public GameObject jiao1aliveparticle;
    public GameObject jiao2desert;
    public GameObject jiao2grass;
    public GameObject jiao2aliveparticle;

    public GameObject jiao3desert;
    public GameObject jiao3grass;
    public GameObject jiao3aliveparticle;
    public GameObject holdR;

    bool green1=false;
    bool green2 = false;
    bool green3 = false;

    public AudioClip aliveparticlesound;


    public GameObject Treeparticle;

    public GameObject flowertree;
    public GameObject spinlifeparticle;

    public AudioClip flowermusic;
     AudioSource boyaudio;

    public AudioClip aftertree;

    public GameObject deadtree;
    public GameObject flowergroup;

    public GameObject treecamera;

    public GameObject desertui;

    public bool inattackarea = false;
    public GameObject magicball;

    public bool ballisflying = false;

    public GameObject ball;
    public GameObject enemy2;

    public float fireRate = 0.5F;//0.5秒实例化一个子弹
    private float nextFire = 0.0F;

    public string b;

    public GameObject jiaoparticle1;
    public GameObject jiaoparticle2;
    public GameObject jiaoparticle3;

    public AudioClip afterfog;


    Animator boyanim;
    public GameObject desert;

    public bool turngreen = false;

    public GameObject greenstone;

    int hitstonecount = 0;

    public Slider greenslider;

    public GameObject lifewallcircle;

    public AudioClip shaonv;
    GameObject[] dirtstone;

    public GameObject desertobj;
    public GameObject forestobj;

    GameObject whatistree;

    public GameObject killguideparticle;
    public GameObject lavastone;

    public AudioClip finalmusic;

 //   public GameObject deer;
    public GameObject magiciangood;


    public GameObject gameendingsnow;

    public AudioClip childrenlaugh;
    public GameObject endingui;

    public bool meetqiuqian = false;

    public AudioClip girlendingclip;
    public GameObject girlendingtext;


    AudioSource endingaudio;

    public GameObject thanksforplaying;
    public GameObject exitbutton;

    public GameObject howtorain;
    public GameObject howtorainbutton;

    public GameObject arrow;
    int inrain = 0;

  //  public GameObject arrow2;
    // Use this for initialization
    void Start () {
        flowertext = flowercount.GetComponent<Text>();
        flowertext.text = "0";
        Chooseorbs.SetActive(false);
        BoyMove = GetComponent<BoyMove2>();
        manager = gamemanager.GetComponent<GameManagerSec>();
        boyanim = this.GetComponent<Animator>();

        pushsource = gameObject.AddComponent<AudioSource>();
     firesound = fireparticle.GetComponent<AudioSource>();
        boyaudio = GetComponent<AudioSource>();
        enemyanim = enemy.GetComponent<Animator>();
        enemyscript = enemy.GetComponent<Enemy>();

        mist = manager.GetComponent<DemoWalk>();
        cameraT = maincamera.GetComponent<Transform>();
        rainparticle1.SetActive(false);
        rainparticle2.SetActive(false);
        rainparticle3.SetActive(false);


        jiao1.gameObject.SetActive(false);
        jiao1grass.SetActive(false);
        jiao1aliveparticle.SetActive(false);

        jiao2.gameObject.SetActive(false);
        jiao2grass.SetActive(false);
        jiao2aliveparticle.SetActive(false);

        jiao3.gameObject.SetActive(false);
        jiao3grass.SetActive(false);
        jiao3aliveparticle.SetActive(false);

        holdR.SetActive(false);

        Treeparticle.SetActive(false);

        flowertree.SetActive(false);
        spinlifeparticle.SetActive(false);
        flowergroup.SetActive(false);

        desertui.SetActive(false);
        jiaoparticle1.SetActive(false);
        jiaoparticle2.SetActive(false);
        jiaoparticle3.SetActive(false);

        desert.SetActive(false);
        greenslider.gameObject.SetActive(false);
        lifewallcircle.SetActive(false);
        forestobj.SetActive(false);

        gameendingsnow.SetActive(false);
        endingui.SetActive(false);
        girlendingtext.SetActive(false);
        //    deer.SetActive(false);

        endingaudio = this.gameObject.AddComponent<AudioSource>();
        endingaudio.clip = girlendingclip;


        thanksforplaying.SetActive(false);
        exitbutton.SetActive(false);
        arrow.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

    

        if (Input.GetKeyDown(KeyCode.E))
        {
            showorbs = !showorbs;
            Chooseorbs.SetActive(showorbs);


            if (showorbs == true)
            {
                BoyMove.enabled = false;
            }
            else if (showorbs == false)
            { BoyMove.enabled = true; }


            if (manager.magic == GameState2.Girl)
            {
                btngirl.Select();
                btngirl.OnSelect(null);
            }
            else if (manager.magic == GameState2.Deer)
            {
                btnDeer.Select();
                btnDeer.OnSelect(null);
            }
            else if (manager.magic == GameState2.Monster)
            {
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

           
        }

        if (meetqiuqian == true && (manager.magic == GameState2.Girl))
        {
            gameendingsnow.SetActive(true);
            girlendingtext.SetActive(true);
            //endingaudio.Play();
            endingaudio.volume = 1.0f;
            endingaudio.PlayOneShot(girlendingclip);
            boyaudio.volume = 0.2f;

            Invoke("thankyou", 75.0f);
            meetqiuqian = false;


           
        }


        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.R) && (keyframeover1 == false)&&(isjiao1==true)&&(manager.magic==GameState2.Deerrain))
        {
            jiao1.gameObject.SetActive(true);
            rainparticle1.SetActive(true);
            keyframe1++;
            Debug.Log(keyframe1);
            jiao1.value = keyframe1;
        }
        if (keyframe1 == 150)
        {
            keyframeover1 = true;
            rainparticle1.SetActive(false);
            jiao1.gameObject.SetActive(false);
            jiao1aliveparticle.SetActive(true);
            jiao1grass.SetActive(true);
            jiao1desert.SetActive(false);
        //    AudioSource.PlayClipAtPoint(aliveparticlesound, transform.position);
            isjiao1 = false;
            green1 = true;
      
        }


        if (Input.GetKey(KeyCode.R) && (keyframeover2 == false) && (isjiao2 == true) && (manager.magic == GameState2.Deerrain))
        {
            jiao2.gameObject.SetActive(true);
            rainparticle2.SetActive(true);
            keyframe2++;
            Debug.Log(keyframe2);
            jiao2.value = keyframe2;
        }
        if (keyframe2 == 150)
        {
           
            keyframeover2 = true;
            rainparticle2.SetActive(false);
            jiao2.gameObject.SetActive(false);
            jiao2aliveparticle.SetActive(true);
            jiao2grass.SetActive(true);
            jiao2desert.SetActive(false);
          //  AudioSource.PlayClipAtPoint(aliveparticlesound, transform.position);
            isjiao2 = false;
            green2 = true;
        }

        if (Input.GetKey(KeyCode.R) && (keyframeover3 == false) && (isjiao3 == true) && (manager.magic == GameState2.Deerrain))
        {
            jiao3.gameObject.SetActive(true);
            rainparticle3.SetActive(true);
            keyframe3++;
            Debug.Log(keyframe3);
            jiao3.value = keyframe3;
        }
        if (keyframe3 == 150)
        {
            keyframeover3 = true;
            rainparticle3.SetActive(false);
            jiao3.gameObject.SetActive(false);
            jiao3aliveparticle.SetActive(true);
            jiao3grass.SetActive(true);
            jiao3desert.SetActive(false);
         //   AudioSource.PlayClipAtPoint(aliveparticlesound, transform.position);
            isjiao3 = false;
            green3 = true;
        }
   
 
            if ((green1 == true) && (green2 == true) && (green3 == true))
            {
                boyaudio.Pause();
                boyaudio.clip = flowermusic;
            boyaudio.volume = 0.8f;
                boyaudio.loop = false;
                boyaudio.Play();

                treecamera.SetActive(true);
                maincamera.SetActive(false);

                Treeparticle.SetActive(true);
            Invoke("treeturngreen", 1.0f);
            mist.isfog = false;
            turngreen = true;
            
              
            }


        if(ballisflying==true && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

           // Instantiate(ball, enemy2.transform.position, enemy2.transform.rotation);
        }


        if(hitstonecount>=120&&hitstonecount<=130)
        {
            Debug.Log("大参林");
            lifewallcircle.SetActive(true);
         //   boyaudio.Pause();
            boyaudio.volume = 0.8f;
         //   boyaudio.clip = shaonv;
          //  boyaudio.Play();
            dirtstone = GameObject.FindGameObjectsWithTag("turngreenstone");
          //  whatistree = GameObject.FindGameObjectWithTag("tree");
           // Debug.Log(whatistree.name);
            foreach (GameObject singledirstone in dirtstone)
            {
                Debug.Log(singledirstone.name);
                singledirstone.SetActive(false);
                Instantiate(greenstone, singledirstone.transform.position, Quaternion.identity);
            }

            desertobj.SetActive(false);
            forestobj.SetActive(true);
            killguideparticle.SetActive(false);
            lavastone.SetActive(false);
            //   deer.SetActive(true);

            // greenslider.gameObject.SetLayer(20);
            greenslider.gameObject.SetActive(false);
            
            //Invoke("changemusic", 24.0f);
            magiciangood.SetActive(false);

        }

       
      

    }


    void thankyou()
    {
        thanksforplaying.SetActive(true);
        exitbutton.SetActive(true);

    }

    void changemusic()
    {
        boyaudio.Pause();
        boyaudio.clip = finalmusic;
        boyaudio.Play();
    }
    void treeturngreen()
    {   
        spinlifeparticle.SetActive(true);
        flowertree.SetActive(true);
        flowergroup.SetActive(true);
        deadtree.SetActive(false);
        //  Destroy(Treeparticle, 1.0f);
        //  Destroy(spinlifeparticle, 3.0f);
        Invoke("backgroundmusic", 9.9f);
        
        green1 = green2 = green3 = false;
        Debug.Log(green1);
        //yield return new WaitForSeconds(0.1f);

    }

   void backgroundmusic()
    {
        boyaudio.Pause();
        boyaudio.clip = aftertree;
        boyaudio.loop = true;
        boyaudio.Play();
        Debug.Log("backgroundmusic function");
        treecamera.SetActive(false);
        maincamera.SetActive(true);
        // Destroy(Treeparticle, 1.0f);
        // Destroy(spinlifeparticle, 3.0f);
    //    yield return new WaitForSeconds(0.1f);
        green1 = green2 = green3 = false;
    }

    //void backgroundmusic()
    //{
    //    boyaudio.Pause();
    //    boyaudio.clip = aftertree;
    //    boyaudio.Play();
    //    Debug.Log("backgroundmusic function");
    //   // Destroy(Treeparticle, 1.0f);
    //   // Destroy(spinlifeparticle, 3.0f);
    //    green1 = green2 = green3 = false;
    //}

    public static void SetMaterialRenderingTransparent(Material material)
    {
                     
        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        material.SetInt("_ZWrite", 0);
      
        material.DisableKeyword("_ALPHATEST_ON");
        material.DisableKeyword("_ALPHABLEND_ON");
        material.EnableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = 3000;

        
    }

    public static void SetMaterialRenderingOpaue(Material material)
    {

        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
        material.SetInt("_ZWrite", 1); material.DisableKeyword("_ALPHATEST_ON");
        material.DisableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = -1;

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="inside")
        {
            castle.GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(0.29f, 0.28f, 0.18f, 0.4f));
            SetMaterialRenderingTransparent(castle.GetComponent<MeshRenderer>().material);
            AudioSource.PlayClipAtPoint(feixu, transform.position);

        }
        if (other.tag == "Dead")
        {
            AudioSource.PlayClipAtPoint(deadsound, transform.position);
            transform.position = new Vector3(-1.21f, -0.85f, 0f);
        }

        if (other.tag=="Dead2")
        {
            AudioSource.PlayClipAtPoint(deadsound, transform.position);
            transform.position = new Vector3(-1.21f, 3f, 11.29f);
        }

        if (other.tag == "Dead3")
        {
            Debug.Log("just dead in zone3");
            AudioSource.PlayClipAtPoint(deadsound, transform.position);
            transform.position = new Vector3(-1.4f, 3f, 25f);
        }

        if (other.tag=="monsterfire")
        {
            firesound.Play();
        }
        if((other.tag=="enemy")&&(enemyscript.dead==false))
        {
            enemyanim.SetBool("iswalk", true);
            meetenemy = true;
            AudioSource.PlayClipAtPoint(enemylaugh, transform.position);
        }
    if(other.tag=="bird")
        {
            AudioSource.PlayClipAtPoint(bird, transform.position);
        }
        if (other.tag == "tree")
        {
            Debug.Log("tree!");
          cameraT.transform.localEulerAngles=new Vector3(-10,0,0);
        }
        if (other.tag=="fogcome")
        {

            boyaudio.Pause();
            boyaudio.clip = afterfog;
            boyaudio.Play();

            mist.isfog = true;
            Quaternion target = Quaternion.Euler(5.16f, 0,0);
            maincamera.transform.localEulerAngles = new Vector3(-1.2f,0,0);
            maincamera.transform.localPosition = new Vector3(-0.04f, -1.45f, -1.02f);
        }

        if(other.tag=="rain")
        {
            israin = true;
            
            Debug.Log("give me some rain");
            desertui.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            if (inrain == 0)
            {
                howtorain.SetActive(true);
                howtorainbutton.SetActive(true);
                inrain = 1;
            }
           // arrow2.SetActive(false);
        }

        if(other.tag=="jiao")
        {
            keyframe1 = 0;
            keyframeover1 = false;
            isjiao1 = true;
            isjiao2 = false;
            isjiao3 = false;
            Debug.Log("jiao");
            jiaoparticle1.SetActive(true);
           if( manager.magic == GameState2.Deerrain)
            {
                holdR.SetActive(true);
            }
        }

        if(other.tag=="jiao2")
        {
            keyframeover2 = false;
            keyframe2= 0;
            isjiao2 = true;
            isjiao1 = false;
            isjiao3 = false;
            jiaoparticle2.SetActive(true);
        }
        if (other.tag == "jiao3")
        {
            keyframeover3 = false;
            keyframe3 = 0;
            isjiao3 = true;
            isjiao1 = false;
            isjiao2 = false;
            jiaoparticle3.SetActive(true);
        }

        if (other.tag == "statue")
        {
            Debug.Log("statue of maigc");
            desertui.SetActive(true);
        }

        if (other.tag == "attack")
        {
            Debug.Log("inside attack area");
            inattackarea = true;
            ballisflying = true;

            Vector3 fromdir = enemy2.transform.forward;
            Vector3 todir = this.transform.forward;
            ballisflying = true;
           
        }


        if(other.tag=="ball")
        {
            Debug.Log("击中");
        }

        if(other.tag=="gotothree")
        {
            this.transform.position = new Vector3(-0.03f, -0.915f, 35.223f);
            desert.SetActive(true);        }




        if(other.tag=="child")
        {
            AudioSource.PlayClipAtPoint(childrenlaugh, transform.position);
            
            endingui.SetActive(true);
            meetqiuqian = true;
            Invoke("endinguifalse", 3.0f);
            
            
        }

    }
    void endinguifalse()
    {
        endingui.SetActive(false);
      
       // AudioSource.PlayClipAtPoint(girlendingclip, transform.position);
            



    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="attack")
        {
            // createball();
          
          
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "inside")
        {
            castle.GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(0.29f, 0.28f, 0.18f, 0.4f));
            SetMaterialRenderingOpaue(castle.GetComponent<MeshRenderer>().material);

        }

        if(other.tag=="rain")
        {
            israin = false;
            desertui.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        if (other.tag == "attack")
        {
            Debug.Log("inside attack area");
            inattackarea =false;
            ballisflying = false;
        }
       

    }


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((hit.collider.tag == "Push") && (manager.magic == GameState2.Monster))
        {
            pushsource.clip = pushbox;
            hit.gameObject.AddComponent<Rigidbody>();
            Rigidbody body = hit.collider.attachedRigidbody;
            body.isKinematic = false;
            body.mass = 1000;
            body.AddForce(new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z) * 10);
            body.constraints = RigidbodyConstraints.FreezePositionY;
            body.constraints = RigidbodyConstraints.FreezeRotation;

            // body.velocity = new Vector3(1, 0, 1) * 30.0f;
            // GameObject clone3 = Instantiate(boxcrushparticle, hit.transform.position, Quaternion.identity);
            //  Destroy(clone3, 1.0f);
            Debug.Log("skr");


        }

        if(hit.collider.tag=="enemy")
        {
            AudioSource.PlayClipAtPoint(deadsound, transform.position);
            transform.position = new Vector3(-1.4f, 3f, 25f);
            hit.transform.position = new Vector3(1.7f, 2.55f, 31.72f);
          //  enemyanim.SetBool("iswalk", false);
        }


        if(hit.collider.tag=="magician")
        {
            AudioSource.PlayClipAtPoint(deadsound, transform.position);

        }

        if((hit.collider.tag=="pusha") && (manager.magic == GameState2.Monster)&&(b=="haha"))
        {
            boyanim.SetBool("push", true);
            hit.collider.gameObject.AddComponent<Rigidbody>();

            Rigidbody body1 = hit.collider.attachedRigidbody;
            body1.isKinematic = false;
            body1.mass = 1000;
            body1.AddForce(new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z) * 10);
           // body1.constraints = RigidbodyConstraints.FreezePositionY;
         //   body1.constraints = RigidbodyConstraints.FreezeRotation;
            Debug.Log(b);
            arrow.SetActive(true);
         

        }

        if ((hit.collider.tag == "pusha") && (manager.magic == GameState2.Monster) && (b != "haha"))
        {
            Debug.Log("对话先");
            Debug.Log(b);
            AudioSource.PlayClipAtPoint(deadsound, transform.position);
            boyanim.SetBool("isinjure", true);
            //boyanim.SetBool("walk", false);
          //  BoyMove.enabled = false;
            Invoke("reidle", 1.5f);


        }
        if ((hit.collider.tag == "turngreenstone") && (turngreen==true))
        {
            Debug.Log("开始了！");
            greenslider.gameObject.SetActive(true);
            greenslider.value = hitstonecount;
            hitstonecount++;
            Debug.Log(hitstonecount);
            Instantiate(greenstone, hit.gameObject.transform.position, Quaternion.identity);
            //Instantiate(jiaoparticle1,transform.position, Quaternion.identity);

            hit.collider.gameObject.SetActive(false);
           // Destroy(jiaoparticle1, 2.0f);
            


        }





    }


    void reidle()
    {
        boyanim.SetBool("isinjure", false);
       //BoyMove.enabled = true;
    }

    public void Conend(string a)
    {
        b = a;
        Debug.Log(b);
    }










}




