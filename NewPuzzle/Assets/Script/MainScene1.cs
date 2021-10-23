using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene1 : MonoBehaviour
{

    public Image StartSelect;

    // Start is called before the first frame update
    void Start()
    {
        StartSelect.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("StageSelect");
    }
    public void GoToStage()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void GameExit()
    {
        Application.Quit();
    }

}
