using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    private Animator animator;
    public GameObject obj_open,obj_close;
    bool _open = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerOpen()
    {
        //bool isOpen = animator.GetBool("Book_open");

        //animator.SetBool("Book_open", !isOpen);

        //obj.transform.Rotate(0.0f, 0.0f, -180.0f, Space.Self);
        //obj.transform.Rotate(Vector3.up, -180.0f);

        if (_open)
        {
            obj_open.SetActive(true);
            obj_close.SetActive(false);
        }
        else
        {
            obj_open.SetActive(false);
            obj_close.SetActive(true);
        }
            

        
    }
}
