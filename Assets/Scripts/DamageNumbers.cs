using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageNumbers : MonoBehaviour
{

    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);

        float xOffset = Random.Range(-0.5f, 0.5f);
        transform.localPosition += new Vector3(xOffset, 0.5f, 0);
    }
}
