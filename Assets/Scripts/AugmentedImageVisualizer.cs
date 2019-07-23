using System;
using System.Collections;
using System.Collections.Generic;
using GoogleARCore;
using UnityEngine;
using UnityEngine.Video;

public class AugmentedImageVisualizer : MonoBehaviour
{
    private VideoPlayer _videoPlayer;

    public AugmentedImage Image;

    [SerializeField] private VideoClip[] _videoClips;

    void Start()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.loopPointReached += OnStop;
        

    }

    private void OnStop(VideoPlayer source)
    {
        gameObject.SetActive (false);
    }

    void Update()
    {
        if (Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            return;
        }

        if (!_videoPlayer.isPlaying)
        {
            _videoPlayer.clip = _videoClips[Image.DatabaseIndex];
            _videoPlayer.Play();
        }

        transform.localScale = new Vector3(Image.ExtentX, Image.ExtentZ, 1);
        
    }
}
