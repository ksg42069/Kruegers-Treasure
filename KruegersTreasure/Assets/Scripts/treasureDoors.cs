using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureDoors : MonoBehaviour
{
    public GameObject book, doors;
    public Transform location1;
    public Animator animator;
    void Start()
    {
        book = GetComponent<GameObject>();
        doors = GetComponent<GameObject>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(book.transform.position, location1.position)<0.2f)
        {
            //animator.Play("treasuredoor1");
            doors.GetComponent<Animator>().Play("treasuredoor1");
        }
    }
}