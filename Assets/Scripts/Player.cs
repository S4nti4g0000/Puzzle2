using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    #region general (speed / rigidbody / Scene change / animator)

    public AudioSource WILLITFUCKINGSOUNDORNOT;

    //Player speed
    public float _cumSpeed = 5f;

    //Player rigidbody
    private Rigidbody2D pussyDistroya;

    //Scene changer
    SceneChange scene;

    //anims
    private Animator animator;
    bool flippedBoi;

    BossFollow bossFollow;

    public int lives = 3;

    #endregion

    #region Ground Check

    //Ground checker
    public Collider2D Gc;
    public Collider2D cP;
    private LayerMask wowLayer;
    private bool hasLanded;

    #endregion

    #region powers general

    public GameObject Kumis;
    public int sceneBuildIndex;

    //Powers
    public bool ClimbOn = false;
    private bool climbingWall;
    public bool jumpyBoi = false;
    public bool strength = false;
    public bool cummyBoi = false;
    public bool legdayBoi = false;

    #endregion

    #region Attack

    public daBaby baby;

    //attack
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyMask;
    private int dmgE = 20;
    private int attackDamage = 50;
    public float furryRate =2f;
    float nextAT = 0f;


    public float cumRate = 0.25f;
    public float canLeak = 0.0f;

    #endregion

    #region Health

    //health & lives
    public int maxHelth = 100;
    public int currHelth = 100;
    public helthPlayer bar;

    #endregion

    void Start()
    {

        pussyDistroya = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        

        if(bossFollow != null)
        {

            bossFollow = GameObject.Find("MiniBoss").GetComponent<BossFollow>();

        }

        currHelth = maxHelth;
        bar.SetMaxPlayerHealth(maxHelth);

    }
    

    void Update()
    {

        MovingBussy();
        climbThatPP();

        if(Input.GetKeyDown(KeyCode.G) && cummyBoi == true)
        {
            GimmeDaCumBlast();
        }

        if(Time.time >= nextAT)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                //pp.attackBussy();
                
                nextAT = Time.time + 1f / furryRate;
                Attacc();
            }
        }



        if (Input.GetKeyDown(KeyCode.P))
        {

            pDmg(10);

        }

        if (cP.IsTouchingLayers(wowLayer = LayerMask.GetMask("Climbable")) && ClimbOn)
        {
            animator.SetBool("ClimbingButStill", true);
        }
        else
        {

            animator.SetBool("ClimbingButStill", false);
        }

    }

    void GimmeDaCumBlast()
    {

        if (Time.time > canLeak)
        {

            Instantiate(Kumis, transform.position + new Vector3(0.65f, 0, 0), Quaternion.identity);
            canLeak = Time.time + cumRate;

        }

    }

    void Attacc()
    {

        animator.SetTrigger("atak");


        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyMask);

        foreach(Collider2D enemy in hitEnemies)
        {

            if(legdayBoi == true)
            {

                attackDamage = 100;

            }

            Debug.Log("Hit da bussy");
            enemy.GetComponent<Enemy>().eDmg(attackDamage);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("ppPlataforma"))
        {

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
            {

                if (hasLanded = Gc.IsTouchingLayers(wowLayer = LayerMask.GetMask("Pisoxd")))
                {




                    float jumpDist = 9f;

                    if (jumpyBoi == true)
                    {

                        jumpDist = 13f;

                    }

                    pussyDistroya.velocity = new Vector3(0, jumpDist, 0);


                }

            }

        }
        SceneChange scene = other.GetComponent<SceneChange>();

        if (other.CompareTag("ExitDoor"))

            
        {
            if(other.CompareTag("ExitDoor") != null)
            {
                scene.whichDoor = 4;
            }           

        }

        if (other.CompareTag("ExitDoor"))
        {

            //StartCoroutine(itHurts());

        }

        if (other.CompareTag("mini_Boss"))
        {

            InvokeRepeating("KiraTwo", 0.1f, 0.2f);

        }

        if (other.CompareTag("powUp"))
        {

            WILLITFUCKINGSOUNDORNOT.Play();

        }

    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("mini_Boss"))
        {
            CancelInvoke("KiraTwo");
            //sbossFollow.BossAnim();
        }

    }

    IEnumerator itHurts()
    {

        yield return new WaitForSeconds(0.5f);

        pDmg(30);
    }

    void KiraTwo()
    {

        pDmg(1);

    }

    public void MovingBussy()
    {

        //Horizontal movement

        

        pussyDistroya.gravityScale = 1f;

        float _hInput = Input.GetAxisRaw("Horizontal");

        

        if(_hInput!= 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _cumSpeed * _hInput);            
        }
        
        if(_hInput > 0)
        {

            gameObject.transform.localScale = new Vector3(5, 5, 1);

            if (cP.IsTouchingLayers(wowLayer = LayerMask.GetMask("Climbable")) && ClimbOn == true)
            {

                animator.SetBool("ClimbMove", true);

            }
            else
            {

                animator.SetBool("ClimbMove", false);
            }

        }
        if(_hInput < 0)
        {

            gameObject.transform.localScale = new Vector3(-5, 5, 1);

            if (cP.IsTouchingLayers(wowLayer = LayerMask.GetMask("Climbable")) && ClimbOn == true)
            {

                animator.SetBool("ClimbMove", true);

            }
            else
            {

                animator.SetBool("ClimbMove", false);
            }

        }


        if(_hInput == 0)
        {

            animator.SetBool("OnGround", false);

        }
        else
        {

            animator.SetBool("OnGround", true);

        }

        //Jumping

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            
            if (hasLanded = Gc.IsTouchingLayers(wowLayer = LayerMask.GetMask("Pisoxd")))
            {
                

                

                float jumpDist = 9f;

                if(jumpyBoi == true)
                {

                    jumpDist = 13f;

                }

                pussyDistroya.velocity = new Vector3(0, jumpDist, 0);
             
             
            }

        }


    }

    public void climbThatPP()
    {
        if(ClimbOn == true)
        {       
            if (climbingWall = cP.IsTouchingLayers(wowLayer = LayerMask.GetMask("Climbable")))
            {
                pussyDistroya.gravityScale = 0f; 
                pussyDistroya.velocity = new Vector3(0,0,0);
                
                float vInput = Input.GetAxis("Vertical");

                transform.Translate(Vector3.up * Time.deltaTime * _cumSpeed * vInput);

            }          
        }
        
    }

    public void canJumpMore()
    {

        jumpyBoi = true;
        StartCoroutine(JumpTimeDownRoutine());

    }

    public void ohWowHeDoesNotSkipLegDay()
    {

        legdayBoi = true;
        StartCoroutine(leVoyAdarEnLaCaraMk());


    }

    public void canCumALot()
    {

        cummyBoi = true;
        StartCoroutine(canCumRoutine());

    }
    public IEnumerator JumpTimeDownRoutine()
    {

        yield return new WaitForSeconds(3.0f);
        jumpyBoi = false; 

    }

    public IEnumerator leVoyAdarEnLaCaraMk()
    {

        yield return new WaitForSeconds(3.0f);
        legdayBoi = false;

    }

    public IEnumerator canCumRoutine()
    {

        yield return new WaitForSeconds(7.0f);
        cummyBoi = false;

    }

    void OnDrawGizmosSelected()
    {

        if(attackPoint == null)
        {

            return;

        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }

    public void pDmg(int dmg)
    {

        currHelth -= dmg;
        bar.SetHealth(currHelth);

        if(currHelth <= 0)
        {
            DeadPlayer();
        }

    }

    public void DeadPlayer()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }

    public void pHeal(int heal)
    {

        currHelth += heal;
        bar.SetHealth(currHelth);

    }

}
