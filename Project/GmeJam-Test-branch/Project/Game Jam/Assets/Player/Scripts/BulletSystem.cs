using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour
{
    

    [SerializeField] private int bulletCount; // The amount of bullets you have in weapon
    [SerializeField] private int bulletsToReload = 10; // The default amount of bullets you will reload
    [SerializeField] private int availableBullets; // The bullets you have in your inventory
    

    private float destroyTime = 2f;
    private void Start()
    {
    }

    private void Update()
    {
        

    }
    

    private bool CheckBulletsToReload()
    {
        if(availableBullets >= bulletsToReload)
        {
            Debug.Log("You have enough bullets to reload");
            return true;
        }

        Debug.Log("You don't have enough bullets to reload");
        return false;
    }

    public void ReloadBullets()
    {
        if (CheckBulletsToReload() == false) return;
        

        availableBullets -= bulletsToReload;
        bulletCount = bulletsToReload;
        Debug.Log("Reloaded");
    }

    public void ReduceBullets()
    {
        if (bulletCount <= 0)
        {
            Debug.Log("I have no more bullets left");
            return;
        }
        bulletCount--;
        
    }
}
