using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour 
{

    [SerializeField]
    private float x_range = 8.0f;
    private float y_range = 4.0f;
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject Target;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(Target, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void newTarget()
    {
        var position = new Vector3(Random.Range(-x_range, x_range), 0, Random.Range(-y_range, y_range));
        Instantiate(Target, position, Quaternion.identity);
    }
}