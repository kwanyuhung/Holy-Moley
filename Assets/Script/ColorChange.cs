using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    private Color color;
    private bool active;
    private float r, g, b;
    private Image background;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
        r = 255;
        g = 210;
        b = 255;
        background = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        while(active)
        {
            for(int i = Convert.ToInt32(b); i >= 210; i--) //Decrease B value
            {
                b = i;
                color = new Color(r, g, b, 1f);
                background.color = color;
            }
            for(int i = Convert.ToInt32(g); i <= 255; i++) //Increase G value
            {
                g = i;
                color = new Color(r, g, b, 1f);
                background.color = color;
            }
            for (int i = Convert.ToInt32(r); i >= 210; i--) //Decrease R value
            {
                r = i;
                color = new Color(r, g, b, 1f);
                background.color = color;
            }
            for (int i = Convert.ToInt32(b); i <= 255; i++) //Increase B value
            {
                b = i;
                color = new Color(r, g, b, 1f);
                background.color = color;
            }
            for (int i = Convert.ToInt32(g); i >= 210; i--) //Decrease G value
            {
                g = i;
                color = new Color(r, g, b, 1f);
                background.color = color;
            }
            for (int i = Convert.ToInt32(r); i <= 255; i++) //Increase R value
            {
                r = i;
                color = new Color(r, g, b, 1f);
                background.color = color;
            }
        }
    }
}
