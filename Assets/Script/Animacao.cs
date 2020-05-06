using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao : MonoBehaviour
{

    Animator anim;
    public float _speed = 0;
    

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("Speed", 0.0f);
    }

    public void BlueButtonAnim()
    {
        anim.SetFloat("Speed", 0.0f);
    }
    public void RedButtonAnim()
    {
        anim.SetFloat("Speed", 0.33f);
    }
    public void YellowButtonAnim()
    {
        anim.SetFloat("Speed", 0.66f);
    }
    public void GreenButtonAnim()
    {
        anim.SetFloat("Speed", 1.0f);
    }
}
