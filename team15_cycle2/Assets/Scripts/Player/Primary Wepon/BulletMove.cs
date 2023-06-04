using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    //private Gun Gun;
    private GameObject Camera;
    
    public float speed = 300f;
    private Vector3 direction;
    //private Vector3 forwards;
    
    void Start()
    {
        Camera = GameObject.Find("PlayerCamera");
        Transform CamPos = Camera.GetComponent<Transform>();

        //Gun = FindFirstObjectByType<Gun>();
        //direction = Gun.point;

        direction = CamPos.transform.forward;
        transform.rotation = Quaternion.LookRotation(-direction);
    }

    void Update()
    {
        //forwards = new Vector3(1, 0, 0);
        transform.position += direction * Time.deltaTime * speed;
    }
}
