using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickStage : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void goToStage1()
    {
        SceneManager.LoadScene("TestStage");
    }
    public void goToStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void goToStage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void goToStage4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void goToStage5()
    {
        SceneManager.LoadScene("Stage5");
    }
    public void goToBack()
    {
        SceneManager.LoadScene("StartSceneNew");
    }
    public void goToSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
