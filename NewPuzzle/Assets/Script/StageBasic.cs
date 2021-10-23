using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageBasic : MonoBehaviour
{
    public Image img;
    public Button bt1;
    public Button bt2;
    public Button closeBt1;
    public Button reStart;
    public Button home1;
    public Button home2;
    public Text timeText;
    public Image Pause;
    public Image clearImg;
    public Text clearTimeText;
    public Text bestTimeText;
    public Image image2x2;
    public Image star1;
    public Image star2;
    public Image star3;

    // Start is called before the first frame update
    void Start()
    {
        img.gameObject.SetActive(false);
        bt1.gameObject.SetActive(false);
        bt2.gameObject.SetActive(false);
        closeBt1.gameObject.SetActive(false);
        reStart.gameObject.SetActive(false);
        timeText.gameObject.SetActive(false);
        Pause.gameObject.SetActive(false);
        clearImg.gameObject.SetActive(false);
        clearTimeText.gameObject.SetActive(false);
        bestTimeText.gameObject.SetActive(false);
        image2x2.gameObject.SetActive(false);
        star1.gameObject.SetActive(false);
        star2.gameObject.SetActive(false);
        star3.gameObject.SetActive(false);
        home1.gameObject.SetActive(false);
        home2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
