using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  private void Start()
  {
    StartCoroutine(Coroutine_Destroy(5.0f));
  }

  private void OnCollisionEnter(Collision collision)
  {
    IDamageable obj = collision.gameObject.GetComponent<IDamageable>();
    if (obj != null) 
    { 
      obj.TakeDamage();
    }
    StartCoroutine(Coroutine_Destroy(0.1f));
  }

  IEnumerator Coroutine_Destroy(float duration)
  {
    yield return new WaitForSeconds(duration);
    Destroy(gameObject);
  }

}
