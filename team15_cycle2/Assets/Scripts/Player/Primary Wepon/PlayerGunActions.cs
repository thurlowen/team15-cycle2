using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunActions : MonoBehaviour
{
    private Gun Gun;

    public void OnShoot()
    {
        Gun.Shoot();
    }
}
