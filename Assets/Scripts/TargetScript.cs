using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum discs {
	inner, middle, outer
}

public class TargetScript : MonoBehaviour
{
    private ScoreScript scoreScript;
    private TargetSpawner targetSpawner;
    private bool allowInput = true;

    [SerializeField]
    private int pointsInner = 5, pointsMiddle = 3, pointsOuter = 1;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        targetSpawner = FindObjectOfType<TargetSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
                
    }

    public void ClickFuntion (discs disc) {
		
        if(allowInput)
        {
            switch (disc)
            {
            case discs.inner:
            print("Wow, inner disc clicked!");
            AddScore(pointsInner);
            break;
            
            case discs.middle:
            print("Middle disc clicked.");
            AddScore(pointsMiddle);
            break;
            
            case discs.outer:
            print("Meh, outer disc clicked..");
            AddScore(pointsOuter);
            break;
            }
        }

		
	}

    void AddScore(int points)
    {
        allowInput = false;
        scoreScript.Score += points;
        scoreScript.UpdateScore(scoreScript.Score);
        DestroyTarget();
    }

    void DestroyTarget()
    {
        Destroy(gameObject);
        //delay would be nice
        allowInput = true;
        targetSpawner.newTarget();
    }
}