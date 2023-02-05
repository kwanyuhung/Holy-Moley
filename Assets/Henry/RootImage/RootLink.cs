using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootLink : MonoBehaviour
{

    public bool isHead = false;
    public RootLink headRoot;
    public bool isDestory = false;
    public RootLink preRoot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("P1"))
        {
            if (isHead)
            {
                StartCoroutine(DestoryHeadRoot());
            }
            else
            {
                StartCoroutine(DestoryRoot());
            }
        }
    }

    public void SetClose()
    {
        isDestory = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHead)
        {
            if (headRoot.isDestory)
            {
                StartCoroutine(DestoryHeadRoot());
            }
        }
        else
        {
            if (preRoot.isDestory)
            {
                StartCoroutine(DestoryRoot());
            }
        }
    }

    IEnumerator DestoryRoot()
    {
        yield return new WaitForSeconds(0.1f);
        isDestory = true;
        gameObject.SetActive(false);
    }

    IEnumerator DestoryHeadRoot()
    {
        yield return new WaitForSeconds(0);
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
