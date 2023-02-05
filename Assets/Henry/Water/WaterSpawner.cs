using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{

    public enum Direction
    {
        UP,
        Down,
        Left,
        Right,
    }
    public Direction direction = Direction.Right;
    public bool waterTriggerOnly = false;


    public float speed = 4f;
    public GameObject WaterStart;
    public GameObject WaterMid;
    public Transform waterEndPoint;

    // Start is called before the first frame update
    void Start()
    {
        if (waterTriggerOnly)
        {
            WaterStart.SetActive(false);
        }


        //float distance = Vector2.Distance(waterEndPoint.localPosition, WaterStart.transform.localPosition);

        //float totalCount = distance;

        //for (int i = 0; i < (int)totalCount; i++)
        //{
        //    var water = Instantiate(WaterMid);
        //    water.transform.parent = transform;

        //    Vector3 pos = Vector3.right;
        //    switch (direction)
        //    {
        //        case Direction.UP:
        //            pos = Vector3.up;
        //            break;
        //        case Direction.Down:
        //            pos = Vector3.down;
        //            break;
        //        case Direction.Left:
        //            pos = Vector3.left;
        //            break;
        //        case Direction.Right:
        //            pos = Vector3.right;
        //            break;
        //    }
        //    //pos *= 0.1f;
        //    water.transform.localPosition = transform.localPosition+ pos * i;
        //    water.transform.localRotation = transform.localRotation;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if (waterTriggerOnly) return;

        if (!WaterStart.activeSelf) WaterStart.SetActive(true);
        if (waterEndPoint.localPosition.x > WaterStart.transform.localPosition.x)
        { 
            WaterStart.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //no self
        if (collision.CompareTag("Water") && collision.gameObject != this.WaterStart)
        {

            Debug.Log(collision.gameObject.name);
            //trigger
            waterTriggerOnly = false;
        }
    }
}
