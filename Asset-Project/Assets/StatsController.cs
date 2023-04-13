using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsController : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim.SetBool("ButtonClick", false);    
    }

    public void buttonClick()
    {
        anim.SetBool("ButtonClick", true);
    }
}
