using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScipt : MonoBehaviour
{
    int laps = 0
    float speed = 0
    float lapProgress = 0

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(Speed); 
        }
    }
       public void GainProgress(float progress)
        {
            curLapProgress += progress;
            Debug.Log("Progress gained: " + progress);
            Debug.Log("Current progress is: " + curLapProgress);
            CheckProgress(curLapProgress);
        }

        pulblic void CheckProgress(float progress)
        {
            if(progress >=reqLapProgress)
            {
                //Completed a lap!

                Debug.Log("We reached the required lap progress!")
            }


        }
}