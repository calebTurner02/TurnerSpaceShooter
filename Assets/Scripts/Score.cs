using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;
    void Start()
    {
        scoreText.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }

    
    public void OnDestroy() 
    {
        score++;
    }

}
