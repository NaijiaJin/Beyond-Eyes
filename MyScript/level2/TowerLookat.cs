using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLookat : MonoBehaviour {

    // Use this for initialization
    public Transform target;
    Interaction interaction;
    public GameObject boy;
    Animator anim;
    public GameObject magicball;
    bool qiuqiu = true;
      

    void Start () {
        interaction = boy.GetComponent<Interaction>();
        anim = GetComponent<Animator>();
        InvokeRepeating("createball", 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
        //当目标对象运动时，始终面向物体

        //transform.LookAt(target);

        //当目标对象运动时，始终转向物体

        //但是尽在Y轴上旋转，而不会上下旋转

        //不造成物体倾斜

        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));

        if(interaction.inattackarea==true)
        {
            anim.SetBool("Misattack", true);
          //  createball();

         


        }

   
        if (interaction.inattackarea == false)
        {
            anim.SetBool("Misattack", false);
            CancelInvoke();
        }
    }

 
}
