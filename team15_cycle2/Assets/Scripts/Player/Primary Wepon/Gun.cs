using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;

    public Camera Camera;
    public GameObject Bullet;
    public float hitThreshold = 0.1f;
    public Vector3 point;

    private MenuManager MenuManager;
    private TimeShifter ts;

    private Vector3 SpawnShift = new Vector3(-0.2f, 0.6f, 0);

    void Start()
    {
        MenuManager = FindFirstObjectByType<MenuManager>();
        ts = GameObject.Find("TowerDamage").GetComponent<TimeShifter>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !MenuManager.pauseMenuActive && ts.isAttack == true)
        {
            //Shoot();

            Bullet = Instantiate(Bullet, transform.position + SpawnShift, Quaternion.identity);
        }
    }

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit))
        {
            //Debug.Log(hit.point);

            point = hit.point;
        }
    }

    private System.Collections.IEnumerator CheckCollision(GameObject bullet, Vector3 targetPoint)
    {
        while (true)
        {
            yield return null;

            float distance = Vector3.Distance(bullet.transform.position, targetPoint);
            if (distance < hitThreshold)
            {
                // Bullet has collided with the target point
                Debug.Log("Bullet hit!");
                Destroy(bullet);
                yield break;
            }
        }
    }
}