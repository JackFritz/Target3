using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    float Cooldown = 0.5f;
    float timer;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        timer = Cooldown;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

      if (Input.GetKeyDown(KeyCode.X) && timer<= 0)
       {
            StartCoroutine(AttackSequence());
            animator.SetBool("IsAttack", true);
            //animator.Play("IsAttack");
            timer = Cooldown;
        }

    }

    public IEnumerator AttackSequence()
    {
        //This is a Coroutine that triggers the box collider to turn on for a brief period
        GetComponent<BoxCollider2D>().enabled = true;
       
        //animator.SetBool("IsAttack", true);
        yield return new WaitForSeconds(.1f);
        animator.SetBool("IsAttack", false);
        GetComponent<BoxCollider2D>().enabled = false;
        
    }
}

//Shawn taught me how to use Coroutines
