using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonkeyScript : MonoBehaviour
{
    public static DonkeyScript Instance { get; private set; }
    private Vector3 TailSpot;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        transform.position = new Vector3(Random.Range(-4f, 4f), -0.2f, -3f);
        TailSpot = transform.GetChild(0).position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GetTailSpot()
    {
        return TailSpot;
    }
}
