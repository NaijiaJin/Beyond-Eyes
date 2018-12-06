using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using VolumetricFogAndMist;

public class Enemy : MonoBehaviour {

    Transform m_transform;
    public Transform Target;
    private NavMeshAgent ag;
    Animator anim;

    Interaction interaction;
    float m_moveSpeed = 0.5f;
    public bool dead = false;

    public GameObject howtodealwith;
    public bool ispause = false;

    public GameObject boy;
    AudioSource boysource;
    public AudioClip signshowsound;
    AudioSource signsource;
    bool signsound=false;
    BoyMove2 boymove;
    public GameObject block;

    public AudioClip enemydiesound;
    public GameObject desert;
    public GameObject manager;

    DemoWalk mist;
    public GameObject evilbtn;
    evilguide guideshow;

    public GameObject showunlock;
    public AudioClip unlock;

    public GameObject portal2;

    // Use this for initialization
    void Start () {
        m_transform = this.transform;
        ag = transform.GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        interaction = Target.GetComponent<Interaction>();
        boysource = boy.GetComponent<AudioSource>();
        signsource = this.gameObject.AddComponent<AudioSource>();
        signsource.clip = signshowsound;
        boymove = boy.GetComponent<BoyMove2>();
        desert.SetActive(false);
        evilbtn.SetActive(false);
          mist = manager.GetComponent<DemoWalk>();
        // VolumetricFog fog = VolumetricFog.instance;
        guideshow = evilbtn.GetComponent<evilguide>();
        showunlock.SetActive(false);
        portal2.SetActive(false);

     

    }
	
	// Update is called once per frame
	void Update () {

        //计算玩家与敌人的距离
        //float distance = Vector3.Distance(transform.position, Target.position);
        ////玩家与敌人的方向向量
        //Vector3 temVec = Target.position - transform.position;
        ////与玩家正前方做点积
        //float forwardDistance = Vector3.Dot(temVec, transform.forward.normalized);
        //if (forwardDistance > 0 && forwardDistance <= 10)
        //{
        //    float rightDistance = Vector3.Dot(temVec, transform.right.normalized);

        //    if (Mathf.Abs(rightDistance) <= 3)
        //    {
        //        Debug.Log("进入攻击范围");
        //       ag.SetDestination(Target.transform.position);
        //        MoveTo();

        //    }
        //    else
        //    {
        //      //  anim.SetBool("iswalk", false);
        //        Debug.Log("不在攻击范围");
        //    }
        //}


        if(interaction.meetenemy==true)
        {
            ag.SetDestination(Target.transform.position);
            MoveTo();
        }
    


        if(ispause==true)
        {
            Time.timeScale = 0;
            boymove.walking = false;
            howtodealwith.SetActive(true);
            boysource.Pause();
            if (Input.GetKey(KeyCode.Space) )

            {
                howtodealwith.SetActive(false);
                ispause = false;
                Time.timeScale = 1;
                boysource.Play();
            }


        }


    }
    void MoveTo()
     {
         //定义敌人的移动量
        float speed = m_moveSpeed * Time.deltaTime;

        //通过寻路组件的Move()方法实现寻路移动
         ag.Move(m_transform.TransformDirection(new Vector3(0, 0, speed)));
     }

void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Dead3")
        {
            AudioSource.PlayClipAtPoint(enemydiesound, transform.position);
            anim.SetBool("isdead", true);
            Invoke("Disappear", 3.0f);
            m_moveSpeed = 0.0f;
            dead = true;
            block.SetActive(false);
            //  desert.SetActive(true);
            portal2.SetActive(true);
            evilbtn.SetActive(false);

            Invoke("Unlockshow", 0.8f);
            
            
       
          

        }

        if(other.tag=="enemymove")
        {
            //howtodealwith.SetActive(true);
            //Time.timeScale = 0;
            ispause = true;
            signsound = true;
            AudioSource.PlayClipAtPoint(signshowsound, transform.position);
            Destroy(other.gameObject);
            evilbtn.SetActive(true);
        }
    }

    void Disappear()
    {
        Destroy(this.gameObject);
    }


    void Unlockshow()
    {
        showunlock.SetActive(true);
        AudioSource.PlayClipAtPoint(unlock, boy.transform.position);
        Invoke("Unlockhide", 2.0f);
    }
    void Unlockhide()
    {
        Destroy(showunlock.gameObject);
    }
}
