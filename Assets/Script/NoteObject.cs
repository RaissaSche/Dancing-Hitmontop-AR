using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour {
    //public bool canBePressed;

    public void OnTriggerEnter2D (Collider2D other) {
        //if (other.tag == "Activator") {
        //    canBePressed = true;
        //}
    }

    public void OnTriggerExit2D (Collider2D other) {
       // if (other.tag == "Activator") {
        //    canBePressed = false;
        //}
    }
}