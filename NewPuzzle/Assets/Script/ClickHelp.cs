using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHelp : MonoBehaviour
{
    public Image img0; //기존에 존제하는 이미지
    public Sprite img1; //바뀌어질 이미지

    public void ChangeImage()
    {
        img0.sprite = img1; //TestImage에 SourceImage를 TestSprite에 존제하는 이미지로 바꾸어줍니다
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
