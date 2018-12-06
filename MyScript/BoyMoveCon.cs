using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BoyMoveCon : MonoBehaviour {

    // Use this for initialization
    private int State;//角色状态
    private int oldState = 0;//前一次角色的状态
    private int UP = 0;//角色状态向前
    private int RIGHT = 1;//角色状态向右
    private int DOWN = 2;//角色状态向后
    private int LEFT = 3;//角色状态向左
    private int IDLE = 4;//角色状态向左
   
    public float speed = 8;
    Animator anim;
    private Vector3 transformValue = new Vector3();//定义平移向量
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

      
        if (Input.GetKeyDown("w")||(Input.GetKey("w")))
        {
            setState(UP);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            setState(IDLE);
        }
        else if (Input.GetKeyDown("s")||(Input.GetKey("s")))
        {
            setState(DOWN);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            setState(IDLE);
        }

        if (Input.GetKeyDown("a")|| (Input.GetKey("a")))
        {
            setState(LEFT);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            setState(IDLE);
        }
        else if (Input.GetKeyDown("d")|| (Input.GetKey("d")))
        {
            setState(RIGHT);
        }
        //if (Input.GetKeyUp(KeyCode.D))
        //{
        //    setState(IDLE);
        //}


    }
    void setState(int currState)
    {
       // Vector3 transformValue = new Vector3();//定义平移向量
        int rotateValue = (currState - State) * 90;
        //  transform.animation.Play("walk");//播放角色行走动画
        anim.SetBool("walk", true);
        switch (currState)
        {
            case 0://角色状态向前时，角色不断向前缓慢移动
               transformValue = Vector3.forward * Time.deltaTime * speed;
                Debug.Log(currState);
                break;
            case 1://角色状态向右时。角色不断向右缓慢移动
                transformValue = Vector3.right * Time.deltaTime * speed;
                break;
            case 2://角色状态向后时。角色不断向后缓慢移动
                transformValue = Vector3.back * Time.deltaTime * speed;
                break;
            case 3://角色状态向左时，角色不断向左缓慢移动
                transformValue = Vector3.left * Time.deltaTime * speed;
                break;
            case 4://角色状态向左时，角色不断向左缓慢移动
                anim.SetBool("walk", false);
                
                break;
        }
        transform.Rotate(Vector3.up, rotateValue);//旋转角色
        transform.Translate(transformValue, Space.World);//平移角色
        oldState = State;//赋值，方便下一次计算
        State = currState;//赋值，方便下一次计算
    }

}
