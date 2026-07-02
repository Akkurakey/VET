using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OurRobotAnimator : MonoBehaviour
{
    private Vector3 rot = Vector3.zero;
    private Animator anim;
    
    // Update is called once per frame
    void Update()
    {
    }

    public void Walk()
    {
        anim.SetBool("Walk_Anim", true);
    }

    public void Idle()
    {
        anim.SetBool("Walk_Anim", false);
    }

}
