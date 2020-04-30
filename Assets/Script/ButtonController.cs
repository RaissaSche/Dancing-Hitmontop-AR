using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    
    private GameObject onButtonArea;

    void Start(){
        onButtonArea = null;
    }

    /*void Update () {
        Debug.Log("Position: " + transform.position);
    }*/

    public void OnTriggerEnter2D (Collider2D collider2D) {
        //Debug.Log("Pegou nota");

        //storing object in the button area
        onButtonArea = collider2D.gameObject;
    }

    public void OnTriggerExit2D (Collider2D collider2D) {
        //Debug.Log("Saiu da área");

        //taking object out of the button area
        onButtonArea = null;
    }

    public void IsPressed () {
        //Debug.Log("Pressionou! onButtonArea: " + onButtonArea);

        float noteDistance = Vector3.Distance(transform.position, onButtonArea.transform.position);
        //checks if object is on button area
        if (onButtonArea) {
            Debug.Log("Pegou nota, dist: " + noteDistance);
            GameManager.instance.increaseScore();
            //AQUI vai a implementação de hit/good/perfect/miss
            //if (note Distance >= 5){ //acertou no limite pra não errar 
                //hit
            //}
            //else if (noteDistance > 2 && noteDistance < 5){ //acertou bem
                //good
            //}
            //else { //chegou bem perto
                //perfect
            //}
            //o 'miss' vai no método de baixo
            Destroy (onButtonArea);
        }
        else{
            Debug.Log("deu ruim, sem nota " + noteDistance);
            if(noteDistance < -1){
                GameManager.instance.resetMultiplier();
                //miss
            }
        }
    }
}