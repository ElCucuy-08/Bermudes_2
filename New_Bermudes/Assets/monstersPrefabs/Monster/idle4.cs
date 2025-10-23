using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class idle4 : StateMachineBehaviour
{
    float timer;
    Transform player;
    float cRange = 30;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            animator.SetBool("walk", true);
        }
        float distance = Vector3.Distance(animator.transform.position, player.position);
        if(distance < cRange)
        {
            animator.SetBool("run", true);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}