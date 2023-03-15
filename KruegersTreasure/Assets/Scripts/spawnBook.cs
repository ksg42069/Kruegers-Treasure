using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBook : MonoBehaviour
{
    public GameObject bookOpen, bookClosed;
    bool _open = false;

    public void OpenTheBook()
    {
        if (!_open)
        {
            Instantiate(bookOpen);
            Destroy(bookClosed);
            _open = true;
        }
        if (_open)
        {
            Instantiate(bookClosed);
            Destroy(bookOpen);
            _open = false;
        }
    }
}
