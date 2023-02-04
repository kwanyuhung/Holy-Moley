using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapBlock : MonoBehaviour
{
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;

    public Vector3 tempPosition1and4;
    public Vector3 tempPosition2and3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Swap1and4();
            Swap2and3();
        }
    }

    public void Swap1and4()
    {
        tempPosition1and4 = block1.transform.position;

        block1.transform.position = block4.transform.position;

        block4.transform.position = tempPosition1and4; 
    }

    public void Swap2and3()
    {
        tempPosition2and3 = block2.transform.position;

        block2.transform.position = block3.transform.position; 

        block3.transform.position = tempPosition2and3;
    }
}
