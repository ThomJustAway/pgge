using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameApp : Patterns.Singleton<GameApp>
{
  bool mPause = false;
  public bool GamePaused
  {
    get { return mPause; }
    set
    {
      mPause = value;
      if (mPause)
      {
        Time.timeScale = 0;
      }
      else
      {
        Time.timeScale = 1;
      }
    }
  }

  private void Start()
  {
    GamePaused = false;
    SceneManager.LoadScene("Menu");
  }

  private void Update()
  {
    if(Input.GetKeyDown(KeyCode.Escape))
    {
      GamePaused = !GamePaused;
    }
  }

}
