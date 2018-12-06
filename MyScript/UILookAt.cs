using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAt : MonoBehaviour {

    public GameObject targetCamera;

    private Vector3 Normal = new Vector3(0, 1, 0);//面法线
    private Quaternion direction;

    // Use this for initialization
    void Start () {
        direction = Quaternion.FromToRotation(new Vector3(0, 1, 0), Normal);

    }

    // Update is called once per frame
    void Update () {
        Look();
    }

    private void Look()
    {
        transform.rotation = targetCamera.transform.rotation * direction;
    }
}
