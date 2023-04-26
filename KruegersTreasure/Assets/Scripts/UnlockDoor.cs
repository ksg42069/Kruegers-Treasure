using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject key;
    

    public void GrabKey()
    {
        StartCoroutine(LevelEnd());
        key = GetComponent<GameObject>();
    }

    IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(3.0f);

        key.SetActive(false);
        this.GetComponent<Animation>().Play("openDoor");
    }
}