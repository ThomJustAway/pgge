using PGGE.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameApp : Singleton<GameApp>
{
    // Start is called before the first frame update
    public AmbientSound mAmbientSound;
    void Start()
    {
        SceneManager.LoadScene(1);
    }

    
}
