using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void OnClick_SinglePlayer()
  {
    SceneManager.LoadScene("SinglePlayerMap00");
  }

  public void OnClick_MultiPlayer()
  {
    SceneManager.LoadScene("MultiPlayer_launcher");
  }
}
