using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{

    float time = 0.0f;


    void Update()
    {
        time += Time.deltaTime;

        if (time >= 0.1f)
        {
            Destroy(gameObject);

            Debug.Log("Destroyed");
        }
    }
}
