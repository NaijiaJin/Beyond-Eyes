using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class storycon : MonoBehaviour {

    public GameObject skip;
    private VideoPlayer videoPlayer;
    private RawImage rawImage;
    // Use this for initialization
    void Start () {
        videoPlayer = this.GetComponent<VideoPlayer>();
        rawImage = this.GetComponent<RawImage>();
        skip.SetActive(false);
        Invoke("howtoskip", 5.0f);
    }

    void howtoskip()
    {
        skip.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        //如果videoPlayer没有对应的视频texture，则返回
        if (videoPlayer.texture == null)
        {
            return;
        }
        //把VideoPlayerd的视频渲染到UGUI的RawImage
        rawImage.texture = videoPlayer.texture;
        if (Input.GetKey(KeyCode.Space))
        {
            Application.LoadLevel("level1");
        }


    }

    void EndReached(VideoPlayer vPlayer)
    {
        Debug.Log("End reached!");
        Application.LoadLevel("level1");
    }
}
