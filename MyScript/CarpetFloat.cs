using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpetFloat : MonoBehaviour {

    public GameObject desertmagician;
    float radian = 0; // 弧度  
    float perRadian = 0.03f; // 每次变化的弧度   上下浮动
    float radius = 0.1f; // 半径  
    Vector3 oldPos; // 开始时候的位置坐标  
                    // Use this for initialization
    void Start () {
        oldPos = transform.position; // 将最初的位置保存到oldPos 
    }
	
	// Update is called once per frame
	void Update () {
        float dx = desertmagician.transform.position.x;
        float dz = desertmagician.transform.position.z;
        radian += perRadian; // 弧度每次加0.03  
        float dy = Mathf.Sin(radian) * radius; // dy定义的是针对y轴的变量，也可以使用sin，找到一个适合的值就可以  
        transform.position = new Vector3(oldPos.x, dy+oldPos.y, oldPos.z); 

    }
}
