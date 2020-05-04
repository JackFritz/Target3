using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBreak : MonoBehaviour
{

    public Animator animator;
    public AudioSource Melee;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Hit", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.name == "AttackBlock")
       {
            StartCoroutine(TargetHitSequence());
            Melee.Play(); //plays the sound insterted in the melee slot

        }

         IEnumerator TargetHitSequence()
        {

            animator.SetBool("Hit", true);
            yield return new WaitForSeconds(.3f);
                   Destroy(gameObject);
                 
                   Score.scoreAmount += 1;

        }
    }
}
