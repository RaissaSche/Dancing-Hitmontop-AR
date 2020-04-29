using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    //public float _speed = 0;

    void Start()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
        anim = GetComponent<Animator>();
    }

    public void RunDownAnim()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetFloat("Speed", 0.66f);
        }
    }

    public void RunUpAnim()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetFloat("Speed", 0.0f);
        }
    }

    public void RunLeftAnim()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetFloat("Speed", 1.0f);
        }
    }

    public void RunRightAnim()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetFloat("Speed", 0.33f);
        }
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    if(_speed > 1.0f)
        //    {
        //        _speed = 0;
        //    }
        //    _speed = _speed + 0.33f;
        //    anim.SetFloat("Speed", _speed);
        //}
    }
}
