using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField]
    private float velocity = 10f;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Cube")==true)
        {
            transform.Rotate(new Vector3(0, 1, 0) * velocity * Time.deltaTime);
        }
        else if (gameObject.CompareTag("Sphere") == true){
            transform.Rotate(new Vector3(0, 1, 0) * velocity * Time.deltaTime);
        }else if (gameObject.CompareTag("Capsule") == true)
        {
            transform.Rotate(new Vector3(0, 0, 1) * velocity * Time.deltaTime);
        }
    }
}
