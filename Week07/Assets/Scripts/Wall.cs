using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour, IDamageable
{
  public AudioClip wallHitAudioClip;
  public AudioSource wallHitAudioSource;

  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {

  }
  public void TakeDamage()
  {
    Debug.Log("Bullet hit");
    wallHitAudioSource.PlayOneShot(wallHitAudioClip);
  }
}
