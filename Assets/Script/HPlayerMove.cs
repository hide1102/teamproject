using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HPlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float xRange;
    [SerializeField] private float zRange;
    public float HitPoints;
    [SerializeField] private Text HPText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && this.transform.position.x < xRange)//Dを押したら かつ　オブジェクトのx座標がxRange以下の値なら
        transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);//移動するためのプログラム
       
       if(Input.GetKey(KeyCode.A) && this.transform.position.x > -xRange)//Aを押したら かつ　オブジェクトのx座標が-xRange以上の値なら
       transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);
    
       if(Input.GetKey(KeyCode.W) && this.transform.position.z < zRange)//Wを押したら かつ　オブジェクトのz座標がzRange以下の値なら
       transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);
    
       if(Input.GetKey(KeyCode.S) && this.transform.position.z > -zRange)//Sを押したら かつ　オブジェクトのz座標が-zRange以上の値なら
       transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);
    
       HPText. text = "HP" + HitPoints. ToString();
       
       if(HitPoints <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other. gameObject. CompareTag("Enemy"))
        {
          HitPoints--; 
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("HEndScene");
    }
}
