using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public AudioSource music;
    public bool startPlaying;
    public BeatScroller beatScroller;
    public GameObject playButton;
    public static GameManager instance;

    void Start () {
        startPlaying = false;
        instance = this;
    }

    void Update () {
        if (startPlaying) {
            Destroy (playButton);
            beatScroller.hasStarted = true;
            music.Play ();
        }
    }

    public void pressStart () {
        startPlaying = true;
    }
}