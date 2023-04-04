using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailScript : MonoBehaviour
{
    private Vector3 TailSpot;
    private Rigidbody rb;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-8.25f, 8.25f), Random.Range(-3f, 4.5f), -3f);
        TailSpot = DonkeyScript.Instance.GetTailSpot();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime + Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        print(Vector3.Distance(transform.position, TailSpot));
    }
}
