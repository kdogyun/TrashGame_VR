using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fedb : MonoBehaviour
{
    public Feedback_Script fb;
    public Text FeedbackText;
    // Use this for initialization
    void Start()
    {
        fb = GameObject.FindGameObjectWithTag("Error").GetComponent<Feedback_Script>();
        for (int i = 0; i < fb.Error.Count; i++)
        {
            FeedbackText.text += "\n" + fb.Tokorean[fb.Error[i]] + "  :  " + fb.feedback[fb.Error[i]];
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}

