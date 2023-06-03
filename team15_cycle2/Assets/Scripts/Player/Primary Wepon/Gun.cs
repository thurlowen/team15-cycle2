using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;

    public Camera Camera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}