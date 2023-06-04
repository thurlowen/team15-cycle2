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

    private TowerAttacks TowerAttacks;
   
    void Start()
    {
        TowerAttacks = FindObjectOfType<TowerAttacks>();
    }
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

    private void OnTriggerEnter(Collider other)
    {
        LookAtCam enemy = other.GetComponent<LookAtCam>();
        if (enemy != null)
        {
            enemy.TakeDamage(TowerAttacks.bullDamage);
            Destroy(gameObject);
        }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
