using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour {

    public float beatTempo; //actual music tempo
    public bool hasStarted;

    void Start () {
        //conversion for Unity frames, adjusting the speed goes per second along
        //example: 120 tempo - 2 units per second
        beatTempo = beatTempo / 60f;
        hasStarted = false;
    }

    void Update () {
        if (hasStarted) {
            transform.position -= new Vector3 (0f, beatTempo * Time.deltaTime 
                                            * 50 /*it was going too slowly*/, 0f);
        }
    }
}