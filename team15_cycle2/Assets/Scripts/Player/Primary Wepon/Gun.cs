using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera Camera;
    public GameObject BulletPrefab;
    public Transform SpawnPoint;
    private float bulletSpeed = 50f;

    private MenuManager MenuManager;
    private TimeShifter ts;

    void Start()
    {
        MenuManager = FindFirstObjectByType<MenuManager>();
        ts = GameObject.Find("TowerDamage").GetComponent<TimeShifter>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !MenuManager.pauseMenuActive && ts.isAttack == true)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, SpawnPoint.position, SpawnPoint.rotation);

        BulletMove bulletMove = Bullet.GetComponent<BulletMove>();
        bulletMove.speed = bulletSpeed;
        bulletMove.direction = SpawnPoint.forward;
    }
}