using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    /// <summary>
    /// 方向向量
    /// </summary>


    public GameObject objectToFollow;

    public float speed = 2.0f;
    // Use this for initialization
    void Start () {
        transform.position=new Vector3(60f, 0.86f, -0.87f);
        transform.SetPositionAndRotation(transform.position,Quaternion.Euler(24.2f,-12.0f,0.0f));
	}
	
	// Update is called once per frame
	void Update () {

        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x, interpolation);

        this.transform.position = position;
    }

    void LateUpdate()
    {
        
    }


}

