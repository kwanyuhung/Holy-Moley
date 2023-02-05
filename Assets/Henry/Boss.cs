using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform up;
    public Transform down;

    public GameObject bullet;

    public GameObject water;

    public void Fire()
    {
        if (!bullet) return;
        var bullet1 = Instantiate(bullet);
        bullet1.SetActive(true);
        bullet1.transform.position = up.transform.position;

        var bullet2 = Instantiate(bullet);
        bullet2.SetActive(true);
        bullet2.transform.position = down.transform.position;


        StartCoroutine(BulletDestory(bullet1, bullet2));
    }

    IEnumerator BulletDestory(GameObject b1,GameObject b2)
    {
        yield return new WaitForSeconds(3f);
        b1.SetActive(false);
        b2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("P1"))
        {
            water.SetActive(true);
        }
    }
}
