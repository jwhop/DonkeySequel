using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailScript : MonoBehaviour
{
    private Vector3 TailSpot;
    [SerializeField] float speed;
    public static TailScript Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-8.25f, 8.25f), Random.Range(-3f, 4.5f), -3f);
        TailSpot = DonkeyScript.Instance.GetTailSpot();
    }

    // Update is called once per frame
    void Update()
    {
        //print(Vector3.Distance(transform.position, TailSpot));
    }
    
}
