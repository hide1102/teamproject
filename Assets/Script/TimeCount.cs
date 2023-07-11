using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour
{
    [SerializeField] private Text TimeText;
    private GameObject data;
    private Data dataCs;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "SampleScene")
        {
            dataCs.elapsedTime += Time.deltaTime;
        }
        
        TimeText.text =  "Time" + dataCs.elapsedTime.ToString("0.00");
    }
}
