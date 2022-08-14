using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crips : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void ScoreUp()
    {
        Score += 1;
        ScoreText.text = Score.ToString();
    }


}
  