using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncaurageWord : MonoBehaviour
{
    [SerializeField] private Text EncourageText;
    private GameObject data;
    private Data dataCs;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();

        if (dataCs.score < 10)
            EncourageText.text = "One More Try";
        if(10 <= dataCs.score && dataCs.score < 20) 
            EncourageText.text = "Cool!";
        if(20 <= dataCs.score && dataCs.score < 30)
            EncourageText.text = "Bravo!!";
        if(30 <= dataCs.score)
            EncourageText.text = "Amazing!!!";
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
