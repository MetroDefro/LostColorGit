using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    int money = 0;
    public Image star1;
    public Image star2;
    public Image star3;

    public Text bestTimeText;

    // Start is called before the first frame update
    void Start()
    {

    }
        // Update is called once per frame
    void Update()
    {
        
    }
    public void plusMoney()
    {
        if (star3.gameObject.activeSelf == true)
        {
            money = 3;
        }
        else if (star2.gameObject.activeSelf == true)
        {
            money = 2;
        }
        else
        {
            money = 1;
        }
        GameObject.Find("SaveData").GetComponent<SaveData>().GetTest(money);

        GameObject.Find("SaveData").GetComponent<SaveData>().GetbestTime(GameObject.Find("timeText").GetComponent<Timer>().timer);
        bestTimeText.text = GameObject.Find("timeText").GetComponent<Timer>().TimeToString(GameObject.Find("SaveData").GetComponent<SaveData>().SetbestTime());
    }
}
