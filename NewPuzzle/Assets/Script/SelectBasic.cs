using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBasic : MonoBehaviour
{
    public Image select1;
    public Image select2;
    public Image select3;
    public Image select4;
    public Image select5;
    public Text moneyText;
    public int money;

    // Start is called before the first frame update
    void Start()
    {
        select1.gameObject.SetActive(false);
        select2.gameObject.SetActive(false);
        select3.gameObject.SetActive(false);
        select4.gameObject.SetActive(false);
        select5.gameObject.SetActive(false);
        money = GameObject.Find("SaveData").GetComponent<SaveData>().SetTest();
        moneyText.text = ""+money;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
