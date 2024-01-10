using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager instance
    {
        get
        {
            if (_instance == null) _instance = new GameManager();
            return _instance;
        }
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
}
