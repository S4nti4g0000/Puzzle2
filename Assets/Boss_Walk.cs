using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Walk : StateMachineBehaviour
{

    public float speed = 2.5f;
    public float attackRange = 3f;

    Transform Slayer;
    Rigidbody2D anim;
    daBoss boss; 


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Slayer = GameObject.FindGameObjectWithTag("Distroya").transform;
        anim = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<daBoss>();
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        //boss.LookAtPlayer();

        Vector2 target = new Vector2(Slayer.position.x, anim.position.y);
        Vector2 newPos = Vector2.MoveTowards(anim.position, target, speed * Time.fixedDeltaTime);
        anim.MovePosition(newPos);

        if (Vector2.Distance(Slayer.position, anim.position) <= attackRange)
        {

            animator.SetTrigger("Attack");

        }

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        animator.ResetTrigger("Attack");

    }


}
