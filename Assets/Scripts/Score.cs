using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI _text;

    private void Start()
    {
        score = 0;
        _text = gameObject.GetComponent<TextMeshProUGUI>();
    }
    public void ChangeScore()
    {
        score++;
        _text.text = score.ToString();
    }
}
