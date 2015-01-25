using UnityEngine;
using System.Collections;

public class Sneeze : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = transform.parent.parent.parent.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Feather")
        {
            animator.SetTrigger("sneeze");
        }
    }
}
