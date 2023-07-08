using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    [SerializeField] private Text TimeText;
    public float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        TimeText.text = "Time" + Time.deltaTime.ToString();
        
        elapsedTime += Time.deltaTime;
        TimeText.text =  "Time" + elapsedTime.ToString("0.00");
    }
}