using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class R_Controller : MonoBehaviour
{
    public GameObject R_Hand;
    public bool Isholding;
    public Moveable_Object mo;
    public GameObject col;
    public bool trigger;
    // Start is called before the first frame update
    void Start()
    {
        Isholding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Isholding)
        {
            if (Vector3.Distance(col.transform.position, R_Hand.transform.position) != 0)
            {
                if (SteamVR_Input._default.inActions.GrabPinch.GetState(SteamVR_Input_Sources.RightHand))
                {
                    trigger = true;
                    mo.Isholded = true;
                  //  col.transform.LookAt(R_Hand.transform);
                    mo.rb.velocity = (R_Hand.transform.position - col.transform.position) * mo.MoveSpeed;
                    col.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player.ID);
                }
                else
                {
                    trigger = false;
                    mo.Isholded = false;
                }
            }
            else
            {
                mo.rb.velocity = (R_Hand.transform.position - col.transform.position) * 0;

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!trigger)
        {
            if (mo == null || !mo.Isholded)
            { 
                 Isholding = true;
                 if (other.GetComponent<Moveable_Object>())
                    mo = other.GetComponent<Moveable_Object>();
                 col = other.gameObject;
             }
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (!SteamVR_Input._default.inActions.GrabPinch.GetState(SteamVR_Input_Sources.RightHand))
        {
            mo.Isholded = false;
            mo = null;
            col = null;
            Isholding = false;
        }
    }

}
