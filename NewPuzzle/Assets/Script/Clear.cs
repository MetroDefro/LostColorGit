using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
    public GameObject[] tile = new GameObject[3];
    public GameObject[] trueTile = new GameObject[3];
    public Image clearImg;
    public Text clearTimeText;
    public Text bestTimeText;
    public Button stop;
    public Image image2x2;
    public Image star1;
    public Image star2;
    public Image star3;
    public Button home2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(tile[0].transform.position, trueTile[0].transform.position)<= 1)
            if(Vector2.Distance(tile[1].transform.position, trueTile[1].transform.position)<= 1)
                if(Vector2.Distance(tile[2].transform.position, trueTile[2].transform.position)<= 1)
                {
                    home2.gameObject.SetActive(true);
                    clearImg.gameObject.SetActive(true);
                    clearTimeText.gameObject.SetActive(true);
                    bestTimeText.gameObject.SetActive(true);
                    stop.gameObject.SetActive(false);
                    image2x2.gameObject.SetActive(true);
                    if(GameObject.Find("timeText").GetComponent<Timer>().timer <= 30)
                    {
                        star3.gameObject.SetActive(true);
                    }
                    else if(GameObject.Find("timeText").GetComponent<Timer>().timer <= 110)
                    {
                        star2.gameObject.SetActive(true);
                    }
                    else
                    {
                        star1.gameObject.SetActive(true);
                    }
                        
                }
                    

    }
}
