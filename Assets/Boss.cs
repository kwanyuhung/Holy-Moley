using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform up;
    public Transform down;

    public GameObject bullet;

    public void Fire()
    {

        var bullet1 = Instantiate(bullet);
        bullet1.SetActive(true);
        bullet1.transform.position = up.transform.position;

        var bullet2 = Instantiate(bullet);
        bullet2.SetActive(true);
        bullet2.transform.position = down.transform.position;
    }
}
