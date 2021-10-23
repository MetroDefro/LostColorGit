using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    public Image StartSelect;
    public Image fade;
    float fades = 1.0f;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartSelect.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 
        time += Time.deltaTime;
        if(fades > 0.0f && time >= 0.1f)
        {
            fades -= 0.1f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;
        } else if (fades <= 0.0f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                SceneManager.LoadScene("Story");
        }
    }
    public void GoToStory()
    {
        SceneManager.LoadScene("Story");
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
