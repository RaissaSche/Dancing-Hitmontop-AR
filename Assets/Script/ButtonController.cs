using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    public Text debugText;
    private GameObject onButtonArea;

    void Start(){
        onButtonArea = null;
    }

    void Update () {
        debugText.text = "Position: " + transform.position;
    }

    public void OnTriggerEnter2D (Collider2D collider2D) {
        Debug.Log("Pegou nota");
        //storing object in the button area
        onButtonArea = collider2D.gameObject;
    }

    public void OnTriggerExit2D (Collider2D collider2D) {
        Debug.Log("Saiu da área");
        //taking object out of the button area
        onButtonArea = null;
    }

    public void IsPressed () {
        Debug.Log("Pressionou! onButtonArea: " + onButtonArea);
        //checks if object is on button area
        if (onButtonArea) {
            float noteDistance = Vector3.Distance(transform.position, onButtonArea.transform.position);
            debugText.text = "Pegou nota, dist: " + noteDistance;
        }
        else{
            debugText.text = "deu ruim, sem nota";
        }
    }
}