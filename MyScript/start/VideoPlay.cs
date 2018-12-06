using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour {

    // Use this for initialization

    private VideoPlayer videoPlayer;
    private RawImage rawImage;
    void Start () {
        
        videoPlayer = this.GetComponent<VideoPlayer>();
        rawImage = this.GetComponent<RawImage>();
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
       if(Input.anyKey)
        {
            Application.LoadLevel("story");
        }
        
    }

    



}
