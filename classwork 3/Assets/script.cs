using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;
    public int increase = 1;
    public Text increasetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scorepoints() 
    {
        score += increase;
        scoretext.text = score.ToString();
    }
    public void inc() 
    {
        if(score >= 10) 
        {
            score -= 10;
            increase += 1;
            increasetext.text ="Points per click " + increase;
        }
    }
}
