using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour
{

    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;
    [SerializeField] private Animator animator;

    float isSeen;
    public float watchTime;
    bool seeInvoke;
    bool isWalkedPast;
    bool canInvoke;
    bool chasing;
    float timeBeforeChase = 2;
    float countingdown;
    public GameObject playerView;
    public GameObject monster;
    public LayerMask canSeeLayer;
    public float monsterSpeed;
    float attackCooldown = 2f;
    float attackTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        seeInvoke = true;
        isSeen = watchTime;
        isWalkedPast = false;
        canInvoke = true;
        chasing = false;
        countingdown = timeBeforeChase;
        animator = GetComponent<Animator>();
    }    


    void Update()
    {
        speedHandler();
        if (chasing)
        {
            if(target != null)
            {
                agent.SetDestination(target.position);
            }
        } 

        if(isWalkedPast)
        {
            if (!chasing && canInvoke)
            {
                Invoke("countdown", .5f);
                canInvoke = false;
            }
            
        }
        else
        {
            countingdown = timeBeforeChase;
        }
        if(countingdown <= 0 && isSeen <= 0)
        {
            chasing = true;
        }

        if (!chasing && seeInvoke)
        {
            Invoke("seenCooldown", .5f);
            seeInvoke = false;
        }

        // if agent touches player, player dies
        if (Vector3.Distance(agent.transform.position, target.position) < 5.0f)
        {
            GameManager.Instance.Die();
        }

        if (Vector3.Distance(agent.transform.position, target.position) < 12.0f)
        {
            if (attackTimer <= 0)
            {
                attackTimer = attackCooldown;
                animator.SetTrigger("Attack");
            }
            else
            {
                attackTimer -= Time.deltaTime;
            }
        }
    }
    void seenCooldown()
    {
        if(isSeen > 0)
        {
            isSeen -= .5f;
        }
        seeInvoke = true;
        print("isSeen = " + isSeen);
    }
    public void spottedMonster()
    {
        isSeen = watchTime;
    }
    //Chase Countdown
    void countdown()
    {
        if(countingdown > 0)
        {
            countingdown = countingdown - .5f;
        }
        Debug.Log("countingdown = " + countingdown);
        canInvoke = true;
    }

    public void playerWalkedPast(bool _bool)
    {
        isWalkedPast = _bool;
    }

    void speedHandler()
    {
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

}
