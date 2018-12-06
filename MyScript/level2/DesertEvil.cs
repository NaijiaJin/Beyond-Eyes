using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//再定义一个跟随的目标
public class DesertEvil : MonoBehaviour {
    private NavMeshAgent ag;//定义一个Navigation的对象
    public  GameObject target;
    // Use this for initialization
    void Start () {
        ag = transform.GetComponent<NavMeshAgent>();
        
    }
	
	// Update is called once per frame
	void Update () {
        ag.SetDestination(target.transform.position); //自动寻路
		
	}
}
