using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject followObject;
    public Animator animator;

    public enum State { NONE, WALK, ATTACK, IDLE };

    public State state;

    private void Start()
    {
       // followObject = GameObject.FindGameObjectWithTag("Player");
        animator = this.GetComponent<Animator>();
        state = State.WALK;
    }
    // Update is called once per frame
    void Update()
    {
        if (state == State.WALK)
        {
            agent.isStopped = false;
            agent.SetDestination(followObject.transform.position);
            animator.SetBool("Attack", false);
        }
        else
        {
            agent.isStopped = true;
        }

        if (state == State.ATTACK)
        {
            animator.SetBool("Attack", true);
        }


        float dist = Vector3.Distance(followObject.transform.position, this.transform.position);

        if (dist > 100)
        {
            state = State.IDLE;
            agent.isStopped = true;
        }

        if (dist < 100 && state == State.IDLE)
        {
            state = State.WALK;
            agent.isStopped = false;
            agent.SetDestination(followObject.transform.position);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            state = State.ATTACK;
            print("Estoy chocando con el Player");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            state = State.WALK;
            print("Estoy chocando con el Player");
        }
    }
}