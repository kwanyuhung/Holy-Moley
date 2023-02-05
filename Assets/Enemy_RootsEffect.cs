using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_RootsEffect : MonoBehaviour
{
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(startPos, transform.position) > transform.GetComponent<SpriteRenderer>().size.x)
        {
            var roots = Instantiate(transform.gameObject);
            roots.transform.position = startPos;

            Debug.Log(transform.localRotation);

            roots.transform.localRotation = transform.localRotation;
            startPos = transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            Destroy(transform.GetComponent<Enemy_RootsEffect>());
        }
    }
}
