using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandScript : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float speed;
    private bool isTouchingTail;
    private bool isTouchingDonkey;
    GameObject tail;
    Gamepad gamepad;
    [SerializeField] GameObject WinText;
    [SerializeField] Sprite closeHand, openHand;
    // Start is called before the first frame update
    void Start()
    {
        gamepad = Gamepad.all[0];
        rb = GetComponent<Rigidbody>();
        tail = null;
    }
    private void OnApplicationQuit()
    {
        gamepad.SetMotorSpeeds(0, 0);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = (Vector3.up * Input.GetAxis("Vertical") * speed + Vector3.right * Input.GetAxis("Horizontal") * speed );
        if(gamepad.aButton.isPressed && isTouchingTail && transform.childCount == 0)
        {
            tail.transform.parent.parent = gameObject.transform;
            GetComponent<SpriteRenderer>().sprite = closeHand;
        }
        else if (!gamepad.aButton.isPressed && isTouchingTail && transform.childCount > 0)
        {
            if(tail != null)
            {
                if (isTouchingDonkey)
                {
                    WinText.SetActive(true);
                }
                tail.transform.parent.parent = null;
            }
            GetComponent<SpriteRenderer>().sprite = openHand;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tail"))
        {
            isTouchingTail = true;
            tail = other.gameObject;
            print("Is touching tail!");
        }
        else if (other.CompareTag("donkey"))
        {
            print("is touching donkey");
            isTouchingDonkey = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("tail"))
        {
            isTouchingTail = false;
            tail = null;
        }
        else if (other.CompareTag("donkey"))
        {
            isTouchingDonkey = false;
        }
    }
}
