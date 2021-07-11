using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float zombievie = 10;

    Animator animator;
    public float zombiespeed;

    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = true;
        zombiespeed = 4;
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, zombiespeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Bullet(Clone)")
        {

            zombievie -= 1;
            
            if (zombievie == 0)
            {
                print(zombievie);
                zombiespeed = 0;
                animator.SetBool("Dead", true);

                Destroy(gameObject, 2);

            }
        }
    }
}
