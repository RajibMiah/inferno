using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combo_Script : MonoBehaviour
{
    public GameObject combo;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        Destroy(combo, 3f);
    }
}
