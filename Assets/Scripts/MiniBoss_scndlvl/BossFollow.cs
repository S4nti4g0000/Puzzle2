using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFollow : MonoBehaviour
{

    public Transform BossAttackPoint;
    public Transform target;
    public LayerMask checkPlayer;
    public Animator bossAnim;

    public float BossRange = 2f;
    public float BossCooldown = 0f;
    public float BossAttackSpeed = 2f;
    private int BossDamage = 5;

    public float LimitMovement = 0f;
    public float speedBoss = 5f;
    public float SpeedUpMovement = 7f;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Distroya").GetComponent<Transform>();
    }

    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) > LimitMovement)
        {
            bossAnim.SetTrigger("Moving");
            transform.position = Vector2.MoveTowards(transform.position, target.position, speedBoss * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, target.position) > SpeedUpMovement)
        {
            speedBoss = 15f;
        }
        else if (Vector2.Distance(transform.position, target.position) <= SpeedUpMovement)
        {
            speedBoss = 5f;
        }

        //if (Time.time >= BossCooldown)
        //{

            //BossAttack();
            //BossCooldown = Time.time + 1f / BossAttackSpeed;

        //}
    } 

    //void BossAttack()
    //{

        //Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(BossAttackPoint.position, BossRange, checkPlayer);

        //foreach (Collider2D player in hitPlayer)
        //{
            //player.GetComponent<Player>().pDmg(BossDamage);
            //bossAnim.SetTrigger("Attacking");
            //Debug.Log("attak");
        //}


    //}

    public void BossAnim()
    {

        bossAnim.SetTrigger("Attacking");

    }
            


    void OnDrawGizmosSelected()
    {

        if (BossAttackPoint == null)
            return;

        Gizmos.DrawWireSphere(BossAttackPoint.position, BossRange);

    }    
}
