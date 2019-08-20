using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcollect : MonoBehaviour
{
  
    void Start()
    {
        transform.position = new Vector3(0.0327f, -0.454f, 4.94f);
    } 
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.5f);
        StartCoroutine(Destroy());
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
