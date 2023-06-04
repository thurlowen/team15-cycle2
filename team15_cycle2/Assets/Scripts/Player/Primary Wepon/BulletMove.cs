using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    private float lifeTime = 5f;
    private float timer = 0f;
   

    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;

        timer += Time.deltaTime;
        if (timer >= lifeTime)
        {
            Destroy(gameObject);
            timer = 0f;
        }
    }
}
