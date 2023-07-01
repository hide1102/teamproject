using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float enemySpeed;
    private GameObject data;
    private Data dataCs;
    private GameObject PM;
    private PlayerMove PMCs;
    [SerializeField] private float EnemyLine;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
        
        PM = GameObject.Find("Player");
        PMCs = PM.GetComponent<PlayerMove>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, enemySpeed) * Time.deltaTime);
        
        if(transform.position.z <= EnemyLine)
        {
            PMCs.HitPoints--;
            Destroy(this. gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
        {
            if(other. gameObject. CompareTag("Bullet"))
            {
            dataCs.score++; //Destroyの前に置くこと
            Destroy(this. gameObject);
            }
            if(other. gameObject. CompareTag("Player"))
            {
                Destroy(this. gameObject);
            }
        
        
        }
}
