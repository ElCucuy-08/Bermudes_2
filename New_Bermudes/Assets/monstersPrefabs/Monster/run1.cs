using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class run1 : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform player;
    float aRange = 3;
    float cRange = 30;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        agent.speed = 4;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(animator.transform.position, player.position);
        if(distance < aRange)
        {
            animator.SetBool("attack", true);
            animator.SetBool("run", false);
            animator.SetBool("walk", false);
        }
        if(distance > cRange)
        {
            animator.SetBool("run", false);
        }   
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
        agent.speed = 2;
    }
}
