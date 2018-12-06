﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyMove3 : MonoBehaviour {
    public float speed = 10.0F;
    float ver = 0;
    float hor = 0;
    public float turnspeed = 10;
    Animator anim;
    public bool walking = false;
    CharacterController controller;

    private Vector3 moveDirection = Vector3.zero;
    public float jumpSpeed = 1.0F;
    public float gravity = 20.0F;

    private AudioSource audiosource;
    public AudioClip footstep;
    // Use this for initialization

    public AudioClip jumpsound;
    // Use this for initialization
    void Start () {
        audiosource = this.gameObject.AddComponent<AudioSource>();
        audiosource.loop = true;
        audiosource.volume = 0.3f;
        audiosource.clip = footstep;
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        if (walking == true)
        {

            transform.Translate(0, 0, Time.deltaTime * speed * 5.0f);

            // Debug.Log("where is music?");
        }
        else if (walking == false)
        {
            // audiosource.Pause();
        }
        if (((Mathf.Abs(ver) > 0.001) || (Mathf.Abs(hor) > 0.001)) )
        {

            walking = true;
            anim.SetBool("walk", true);

            //  transform.Translate(0,0,Input.GetAxis("Vertical")* speed*0.01f);
        }


        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("walk", false);
            walking = false;
            audiosource.Pause();
            anim.SetBool("push", false);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("walk", false);
            walking = false;
            audiosource.Pause();
            anim.SetBool("push", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("walk", false);
            walking = false;
            audiosource.Pause();
            anim.SetBool("push", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("walk", false);
            walking = false;
            audiosource.Pause();
            anim.SetBool("push", false);
        }
        if (controller.isGrounded)
        {
            anim.SetBool("jump", false);
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
                anim.SetBool("jump", true);
                AudioSource.PlayClipAtPoint(jumpsound, transform.position);
                transform.parent = null;
                controller.Move(moveDirection * Time.deltaTime);
            }

            //if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.A)))
            //{
            //    audiosource.Play();
            //}


        }

        // 
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;

            controller.Move(moveDirection * Time.deltaTime);
        }

        if (hor != 0 || ver != 0)
        {
            //转身
            Rotating(hor, ver);



        }
    }


    void Rotating(float hor, float ver)
    {
        //获取方向
        Vector3 dir = new Vector3(hor, 0, ver);
        //将方向转换为四元数
        Quaternion quaDir = Quaternion.LookRotation(dir, Vector3.up);
        //缓慢转动到目标点
        transform.rotation = Quaternion.Lerp(transform.rotation, quaDir, Time.fixedDeltaTime * turnspeed);



    }

  //  void FixedUpdate()
  //  {


       

  //  }
}
