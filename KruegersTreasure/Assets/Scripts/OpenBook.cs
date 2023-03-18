using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    private Animator animator;
    //public GameObject obj_open,obj_close;
    bool isOpen = false;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerOpen()
    {
        //bool isOpen = animator.GetBool("openBook");

        animator.SetBool("isOpen", true);
        
    }
    public void TriggerClose()
    {
        animator.SetBool("isOpen", false);
    }
}
