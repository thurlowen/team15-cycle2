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
    private float damage = 20;

    private TowerAttacks TowerAttacks;
    private AudioSource gruntAudio;
   
    void Start()
    {
        TowerAttacks = FindObjectOfType<TowerAttacks>();
        gruntAudio = GetComponent<AudioSource>();
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
            enemy.TakeDamage(damage);
            gruntAudio.Play();
            Destroy(gameObject, gruntAudio.clip.length);
        }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
