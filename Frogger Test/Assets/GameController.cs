using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameObject gbInstance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (gbInstance == null)
            gbInstance = this.gameObject;
        else
        {
            Destroy(gameObject);
        }

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 120;
    }
}
