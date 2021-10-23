using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryBasic : MonoBehaviour
{
    public Button st2;
    public Button st3;
    public Button st4;

    // Start is called before the first frame update
    void Start()
    {
        st2.gameObject.SetActive(false);
        st3.gameObject.SetActive(false);
        st4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
