using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour {
    public float beatTempo; //actual music tempo

    void Start () {
        //conversion for Unity frames, adjusting the speed goes per second along
        //example: 120 tempo - 2 units per second
        beatTempo = beatTempo / 60f;
    }

    void Update () {
        transform.position -= new Vector3 (0f, beatTempo * 10 * Time.deltaTime, 0f);
    }
}