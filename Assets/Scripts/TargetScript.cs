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
    //private float delay = 0.5F;
    private int pointsInner = 5;
    private int pointsMiddle = 3;
    private int pointsOuter = 1;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        targetSpawner = FindObjectOfType<TargetSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        //if Target hit
            //search for disc hit
            //if inner disc hit -> AddScore(pointsInner)
            //if middle disc hit -> AddScore(pointsMiddle)
            //if outer disc hit -> AddScore(pointsOuter)
            //destroy Target -> DestroyTarget(target) with animation
            //after destroy -> call to Controller to spawn new Target
        
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
        //delay would be nice, maybe some animation
        allowInput = true;
        targetSpawner.newTarget();
    }
}