using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class L_Controller : MonoBehaviour
{
    public GameObject L_Hand;
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
            if (Vector3.Distance(col.transform.position, L_Hand.transform.position) != 0)
            {
                if (SteamVR_Input._default.inActions.GrabPinch.GetState(SteamVR_Input_Sources.LeftHand))
                {
                    trigger = true;
                    mo.Isholded = true;
                    // col.transform.LookAt(L_Hand.transform);
                    mo.rb.velocity = (L_Hand.transform.position - col.transform.position) * mo.MoveSpeed;
                    col.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player.ID);

                }
                else
                {
                    trigger = false;
                }
            }
            else
            {
                mo.rb.velocity = (L_Hand.transform.position - col.transform.position) * 0;

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
                mo = other.GetComponent<Moveable_Object>();
                col = other.gameObject;
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (!SteamVR_Input._default.inActions.GrabPinch.GetState(SteamVR_Input_Sources.LeftHand))
        {
        mo.Isholded = false;
        mo = null;
        col = null;
        Isholding = false;

        }
    }

}
