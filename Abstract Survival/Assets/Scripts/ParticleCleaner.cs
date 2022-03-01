using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCleaner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeleteSelf());
    }
    IEnumerator DeleteSelf()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
