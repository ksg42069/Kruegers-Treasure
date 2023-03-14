using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    private Animator animator;
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        obj = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerOpen()
    {
        /*bool isOpen = animator.GetBool("Book_open");

        animator.SetBool("Book_open", !isOpen);*/

        //obj.transform.Rotate(0.0f, 0.0f, -180.0f, Space.Self);
        obj.transform.Rotate(Vector3.up, -180.0f);
        
    }
}
