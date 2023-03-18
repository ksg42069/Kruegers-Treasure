using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookanimation : MonoBehaviour
{
    Animation ani;
    bool _open = false;

    private void Start()
    {
        ani = GetComponent<Animation>();        
    }

    public void playAnimation()
    {
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
