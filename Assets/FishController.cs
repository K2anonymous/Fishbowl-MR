using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public Animator animator;
    


    // Start is called before the first frame update
    void Start()
    {
        animator.Play("FF1_slowSwim");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
