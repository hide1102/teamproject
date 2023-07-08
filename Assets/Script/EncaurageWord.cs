using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncaurageWord : MonoBehaviour
{
    [SerializeField] private Text EncourageText;
    private float score;
    private GameObject data;
    private Data dataCs;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();

        if(10 <= score && score < 20) 
            EncourageText.text = "Cool!";
        if(20 <= score && score < 30)
            EncourageText.text = "Bravo!!";
        if(30 <= score)
            EncourageText.text = "Amazing!!!";
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
