using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

public class LaserPoint : MonoBehaviour {

    public GameObject Controller;
    public GameObject laserPrefab;
    private GameObject laser;
    private Transform laserTransform;
    private Vector3 hitPoint;

    // Use this for initialization
    void Start () {
        laser = Instantiate(laserPrefab);
        laserTransform = laser.transform;
    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;

        // 2
        if (Physics.Raycast(Controller.transform.position, transform.forward, out hit, 10))
        {
            hitPoint = hit.point;
            ShowLaser(hit);
        }
        else
        {
            laser.SetActive(false);
        }

        if (SteamVR_Input._default.inActions.GrabPinch.GetState(SteamVR_Input_Sources.Any))
        {
            if (hit.collider.tag == "Start")
            {
                SceneManager.LoadScene("SampleScene");
            }
            if (hit.collider.tag == "Study")
            {

            }
            if (hit.collider.tag == "Finish")
            {
                Application.Quit();
            }
        }
    }

    private void ShowLaser(RaycastHit hit)
    {
        laser.SetActive(true);
        laserTransform.position = Vector3.Lerp(Controller.transform.position, hitPoint, .5f);
        laserTransform.LookAt(hitPoint);
        laserTransform.localScale = new Vector3(laserTransform.localScale.x,laserTransform.localScale.y, hit.distance);
    }
}
