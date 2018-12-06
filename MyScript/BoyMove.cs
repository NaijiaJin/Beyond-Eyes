using System.Collections;
    using System.Collections.Generic;
using UnityEngine;

public class BoyMove : MonoBehaviour {
    public float speed = 0.3F;
    public float rotateSpeed = 90.0F;
    CharacterController controller;
    private Animator anim;
    private bool walking=false;

    public Transform target;
    public Transform targetleft;

    public AudioClip walk_sound;
    private AudioSource audio_source;
    //   private int walkID = Animator.StringToHash("iswalk");
    // Use this for initialization

       
    void Start () {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    void Awake()
    {
        audio_source = GetComponent<AudioSource>();
        //  audio_source.mute = GameInfo.effect_sound_mute;
        audio_source.clip = walk_sound;
    }

    // Update is called once per frame
    void Update () {
        anim.SetFloat("iswalk", Input.GetAxis("Vertical"));
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

    

        if (walking == true)
        {

            transform.Translate(0, 0, Time.deltaTime * speed * 0.18f);
            audio_source.Play();

        }
        else if (walking == false)
        {

            audio_source.Stop();

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = rotation;
       
            walking = true;
            anim.SetBool("walk", true);
            //  transform.Translate(0,0,Input.GetAxis("Vertical")* speed*0.01f);
        }
       
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("walk", false);
            walking =false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(0, 180, 0);
            anim.SetBool("walk", true);
            walking = true;
            //  transform.Translate(0,0,Input.GetAxis("Vertical")* speed*0.01f)
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("walk", false);
            walking = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
            walking =true;
            anim.SetBool("walk", true);
          
            //  transform.Translate(0,0,Input.GetAxis("Vertical")* speed*0.01f)
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            
            anim.SetBool("walk", false);
            walking = false;
        }

    }
}
