using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Events;
using System;
[RequireComponent(typeof(Text))]
[AddComponentMenu("UGUI Writer Effect")]

public class TypeEffect : MonoBehaviour {

    public UnityEvent myEvent;
    //打字速度
    public int charsPerSecond = 3;
    // public AudioClip mAudioClip;             // 打字的声音，不是没打一个字播放一下，开始的时候播放结束就停止播放  
    private bool isActive = false;

    private float timer;
    private string words;
    private Text mText;

    // Use this for initialization
    void Start () {
        if (myEvent == null)
            myEvent = new UnityEvent();

        mText = GetComponent<Text>();
        words = mText.text;
        mText.text = string.Empty;
        timer = 0;
        isActive = true;
        charsPerSecond = Mathf.Max(1, charsPerSecond);

    }

    void ReloadText()
    {
        words = GetComponent<Text>().text;
        mText = GetComponent<Text>();
    }

    public void OnStart()
    {
        ReloadText();
        isActive = true;
    }

    void OnStartWriter()
    {
        if (isActive)
        {
            try
            {

                mText.text = words.Substring(0, (int)(charsPerSecond * timer));
                timer += Time.deltaTime;
            }
            catch (Exception)
            {
                OnFinish();
            }
        }
    }

    void OnFinish()
    {
        isActive = false;
        timer = 0;
        GetComponent<Text>().text = words;
        try
        {
            myEvent.Invoke();
        }
        catch (Exception)
        {
            Debug.Log("问题");
        }
    }



    // Update is called once per frame
    void Update () {
        OnStartWriter();
    }
}
