using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootSpawner : MonoBehaviour
{

    public enum Direction
    {
        UP,
        Down,
        Left,
        Right,
    }
    public Direction direction = Direction.Right;

    public float speed = 4f;
    public GameObject RootStart;
    public GameObject RootMid;
    public Transform RootEndPoint;

    // Start is called before the first frame update
    void Start()
    {
        float distance = Vector2.Distance(RootEndPoint.localPosition, RootStart.transform.localPosition);

        float totalCount = distance;

        RootLink current = transform.GetComponent<RootLink>();

        for (int i = 0; i < (int)totalCount; i++)
        {
            var Root = Instantiate(RootMid);
            Root.SetActive(true);
            Root.GetComponent<RootLink>().preRoot = current;
            current = Root.GetComponent<RootLink>();

            Vector3 pos = Vector3.right;
            switch (direction)
            {
                case Direction.UP:
                    pos = Vector3.up;
                    break;
                case Direction.Down:
                    pos = Vector3.down;
                    break;
                case Direction.Left:
                    pos = Vector3.left;
                    break;
                case Direction.Right:
                    pos = Vector3.right;
                    break;
            }
            pos *= 0.2f;
            Root.transform.localPosition = transform.localPosition + pos * i;
            Root.transform.localRotation = transform.localRotation;

            if (i == (int)totalCount - 1)
            {
                transform.GetComponent<RootLink>().headRoot = Root.GetComponent<RootLink>();
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (RootEndPoint.localPosition.x > RootStart.transform.localPosition.x)
        {
            RootStart.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
