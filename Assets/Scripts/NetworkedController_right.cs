﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkedController_right : Photon.MonoBehaviour {

	public GameObject avatar;
	public Transform playerGlobal;
	public Transform playerLocal;

	// Use this for initialization
	void Start ()
	{
		if (photonView.isMine)
		{
			playerGlobal = GameObject.Find("[CameraRig]").transform;
			playerLocal = playerGlobal.Find("Controller(right)");

			this.transform.SetParent(playerLocal);
			this.transform.localPosition = Vector3.zero;

			//avatar.SetActive(false);
		}
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext(playerGlobal.position);
			stream.SendNext(playerGlobal.rotation);
			stream.SendNext(playerLocal.localPosition);
			stream.SendNext(playerLocal.localRotation);
		}
		else
		{
			this.transform.position = (Vector3)stream.ReceiveNext();
			this.transform.rotation = (Quaternion)stream.ReceiveNext();
			avatar.transform.localPosition = (Vector3)stream.ReceiveNext();
			avatar.transform.localRotation = (Quaternion)stream.ReceiveNext();
		}
	}
}