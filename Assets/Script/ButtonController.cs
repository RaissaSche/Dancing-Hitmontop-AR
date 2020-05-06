using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    private GameObject onButtonArea;
    private Color feedbackColor;
    private bool exitedButtonArea;
    public Animator anim;
    public Image feedback;
    public Sprite good, miss;
    public float _speed = 0;

    void Start () {
        onButtonArea = null;
        anim.SetFloat ("Speed", 0.0f);
        feedbackColor = feedback.color;
        TurnFeedbackInvisible ();
        exitedButtonArea = false;
    }

    void Update () {
        if (onButtonArea != null && onButtonArea.tag == "FeedbackDismisser") {
            TurnFeedbackInvisible ();
        }
    }

    public void IsPressed () {
        //checks if object is on button area
        if (onButtonArea == null) {
            EmptyOnButtonArea ();
        } else if (onButtonArea.tag == "Arrow") {
            ArrowIsOnButtonArea ();
        }
    }

    //Situations Management
    private void ArrowIsOnButtonArea () {
        feedback.GetComponent<Image> ().sprite = good;
        TurnFeedbackVisible ();

        float noteDistance = Vector3.Distance (transform.position, onButtonArea.transform.position);
        GameManager.instance.increaseScore ();
        onButtonArea = null;
    }

    private void EmptyOnButtonArea () {
        if (exitedButtonArea) {
            GameManager.instance.resetMultiplier ();

            feedback.GetComponent<Image> ().sprite = miss;
            TurnFeedbackVisible ();
        }
    }

    //Trigger Management
    public void OnTriggerEnter2D (Collider2D collider2D) {
        //storing object in the button area
        onButtonArea = collider2D.gameObject;
        exitedButtonArea = false; //resets variable
    }

    public void OnTriggerExit2D (Collider2D collider2D) {
        //taking object out of the button area
        onButtonArea = null;
        exitedButtonArea = true;
    }

    //Feedback Management
    private void TurnFeedbackVisible () {
        feedbackColor.a = 1;
        feedback.color = feedbackColor;
    }

    private void TurnFeedbackInvisible () {
        feedbackColor.a = 0;
        feedback.color = feedbackColor;
    }

    //Animations
    public void BlueButtonAnim () {
        anim.SetFloat ("Speed", 0.0f);
    }

    public void RedButtonAnim () {
        anim.SetFloat ("Speed", 0.33f);
    }

    public void YellowButtonAnim () {
        anim.SetFloat ("Speed", 0.66f);
    }

    public void GreenButtonAnim () {
        anim.SetFloat ("Speed", 1.0f);
    }
}