using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameObject Player_Ray;
    public GameObject ScreenPosition;

	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(ScreenPosition.transform.position.x, ScreenPosition.transform.position.y, ScreenPosition.transform.position.z + 0.03f);
        transform.LookAt(Player_Ray.transform);

    }



}
