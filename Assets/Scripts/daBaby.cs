using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class daBaby : MonoBehaviour
{

    #region General Stuff
        
    public float attackDistance;
    public float timer;
    
    [HideInInspector] public Transform target;
    [HideInInspector] public bool inRange;
    public GameObject hotAF;
    public GameObject triggerArea;

    public Transform leftLimit;
    public Transform rightLimit;

    
    #endregion

    #region Private Parts

    public float speedWagonEnemy = 3;
    private Animator anim;
    private float distance;
    private bool attackMode;
    
    private bool cooling;
    private float inTimer;


    Enemy_Spawner spawner;

    #endregion

    #region Scene stuff

    string sceneName;

    #endregion

    void Awake()
    {

        SelectTarget();
        inTimer = timer;
        anim = GetComponent<Animator>();
                
    }

    void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();

        sceneName = currentScene.name;




    }

    void Update()
    {

        if (!attackMode)
        {

            Move();

        }

        if(!InsideofLimits() && !inRange && !anim.GetCurrentAnimatorStateInfo(0).IsName("enemy05"))
        {

            SelectTarget();

        }
      
        if(inRange)
        {

            EnemyLogic();

        }

    }

    void EnemyLogic()
    {

        distance = Vector2.Distance(transform.position, target.position);

        if(distance > attackDistance)
        {

            StopAttack();

        }
        else if(attackDistance >= distance && cooling == false)
        {

            Attack();

        }

        if (cooling)
        {

            anim.SetBool("Attack", false);
            cooldown();

        }

    }

    void Move()
    {

        anim.SetBool("canWalk", true);

        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("enemy05"))
        {

            Vector2 targetPosition = new Vector2(target.position.x, transform.position.y);

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speedWagonEnemy * Time.deltaTime);

        }

    }

    void Attack()
    {

        timer = inTimer;
        attackMode = true;

        anim.SetBool("canWalk", false);
        anim.SetBool("Attack", true);

    }

    void StopAttack()
    {

        cooling = false;
        attackMode = false;
        anim.SetBool("Attack", false);

    }

    public void TriggerCooling()
    {

        cooling = true;

    }

    void cooldown()
    {

        timer -= Time.deltaTime;

        if(timer <= 0 && cooling && attackMode)
        {

            cooling = false;
            timer = inTimer;

        }

    }

    private bool InsideofLimits()
    {

        return transform.position.x > leftLimit.position.x && transform.position.x < rightLimit.position.x;

    }

    public void SelectTarget()
    {

        float distancetoLeft = Vector2.Distance(transform.position, leftLimit.position);
        float distancetoRight = Vector2.Distance(transform.position, rightLimit.position);

        if(distancetoLeft > distancetoRight)
        {

            target = leftLimit;

        }
        else
        {

            target = rightLimit;

        }

        Flipy();

    }

    public void Flipy()
    {

        Vector3 rot = transform.eulerAngles;
        if(transform.position.x > target.position.x)
        {

            rot.y = 180f;

        }
        else
        {

            rot.y = 0f;

        }

        transform.eulerAngles = rot;

    }

    public void DedBoi()
    {

        StartCoroutine(imDed());
        this.enabled = false;

        if(sceneName == "LevelTree")
        {

            spawner = GameObject.Find("EnemySpawn 1").GetComponent<Enemy_Spawner>();
            spawner.deathCount++;

        }

    }

    public IEnumerator imDed()
    {

        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);

    }

}
