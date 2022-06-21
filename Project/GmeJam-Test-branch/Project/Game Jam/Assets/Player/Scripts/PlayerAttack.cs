using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // When player shoots, instantiate the bullet and make it travel to the direction the point was
    [SerializeField] private GameObject bullets;
    [SerializeField] private Camera mainCamera;
    private float destroyTime = 20f;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (bullets == null) return;
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
           //BroadcastMessage("ReduceBullets");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            BroadcastMessage("ReloadBullets");
        }
    }

    void Shoot()
    {
        
        
            //Spawn bullet from your location
        GameObject bullet = Instantiate(bullets, transform.position, Quaternion.identity);
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        
        Vector3 directionToGo = mouseWorldPosition - transform.position;
        mouseWorldPosition.z = 0;
        bullet.GetComponent<Rigidbody2D>().AddForce(directionToGo.normalized * 10, ForceMode2D.Impulse);
        Destroy(bullet, destroyTime);
        
    }
}
