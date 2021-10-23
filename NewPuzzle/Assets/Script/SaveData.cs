using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static int money = 0;
    public static float bestTime = 0;

    class Stage
    {
        bool cleared;
        public void GetStage(bool t)
        {
            cleared = t;
        }

        public bool SetStage()
        {
            return cleared;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void GetTest(int m)
    {
        money += m;
    }

    public int SetTest()
    {
        return money;
    }

    public void GetbestTime(float t)
    {
        if(t > bestTime)
            bestTime = t;
    }

    public float SetbestTime()
    {
        return bestTime;
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
