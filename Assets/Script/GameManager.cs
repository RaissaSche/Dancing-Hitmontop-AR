using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //TODO: PAUSE and EXIT functions
    //TODO: Make button have/be Pokéballs

    public static GameManager instance;

    public AudioSource music;
    public BeatScroller beatScroller;
    public GameObject playButton;

    public Text scoreText;
    public Text multiplierText;

    public int currentScore;
    public int scorePerNote = 100;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    void Start () {
        instance = this;

        currentMultiplier = 1;
        scoreText.text = "Score: 0";
    }

    public void pressStart () {
        beatScroller.hasStarted = true;
        music.Play ();
        Destroy (playButton);
    }

    public void increaseScore () {
        if (currentMultiplier - 1 < multiplierThresholds.Length) {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker) {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        multiplierText.text = "Multiplier: x" + currentMultiplier;

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }

    public void resetMultiplier () {
        currentMultiplier = 1;
        multiplierTracker = 0;

        multiplierText.text = "Multiplier: x" + currentMultiplier;
    }
}