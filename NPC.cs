using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public int nealls = 5;
    public int level = 1;
    public float speed = 1.2f;
    void Start()
    {
        nealls = nealls + level;
        print("жизней" + nealls);
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 newPosition = transform.posinion;
        newPosition.z = speed * Time.deltaTim;
        tranform.posinion = newPosition;
    }
}
