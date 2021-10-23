using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileMove2 : MonoBehaviour
{
    public GameObject slot;
    float xtemp;
    float ytemp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, slot.transform.position) <= 2.1)
        {
            xtemp = transform.position.x;
            ytemp = transform.position.y;
            transform.position = new Vector2(slot.transform.position.x, slot.transform.position.y);
            slot.transform.position = new Vector2(xtemp, ytemp);
        }
    }
}
