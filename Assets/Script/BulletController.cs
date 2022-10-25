using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Arrow());
    }

    IEnumerator Arrow()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject); // Destroy object
    }
}
