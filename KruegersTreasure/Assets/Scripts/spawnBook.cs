using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBook : MonoBehaviour
{
    public GameObject bookOpen, bookClosed;
    public Transform mainBook;
    bool _open = false;
    GameObject spawnOpen, spawnClose;

    private void Start()
    {
        spawnClose = Instantiate(bookClosed, mainBook);
    }
    public void OpenTheBook()
    {
        if (!_open)
        {
            bookOpen = Instantiate(bookOpen, mainBook);
            Destroy(spawnClose);
            _open = true;
        }
        if (_open)
        {
            bookClosed = Instantiate(bookClosed, mainBook);
            Destroy(spawnOpen);
            _open = false;
        }
    }
}
