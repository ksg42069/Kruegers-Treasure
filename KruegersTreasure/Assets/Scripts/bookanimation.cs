using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookanimation : MonoBehaviour
{
    Animator ani;
    bool _open = false;

    private void Start()
    {
        ani = GetComponent<Animator>();        
    }

    public void playAnimation()
    {
        ani = GetComponent<Animator>();

        if (!_open)
        {
            ani.Play("openBook");
            _open = true;
        }
        if (_open)
        {
            ani.Play("closeBook");
            _open = false;
        }

       
    }
}
