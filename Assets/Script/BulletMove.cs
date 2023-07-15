using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bigbulletPrefab;
    private float PushTime = 0;
    private GameObject bullet;
    private GameObject bigbullet;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            PushTime +=Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab. transform. rotation);
            rb = bullet. GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletSpeed);
            Destroy(bullet, lifeTime);
        }

        else if(PushTime >= 1.0f)
        {
            bigbullet = Instantiate(bigbulletPrefab, transform.position, bigbulletPrefab.transform.rotation);
            rb = bigbullet.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletSpeed);
            Destroy(bullet, lifeTime);
            PushTime = 0;
        }

    }
}
