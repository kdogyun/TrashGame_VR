using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreM : Photon.MonoBehaviour, IPunObservable
{

    public int Player1Score = 0;
    public int Player2Score = 0;
    public bool a;

    //Called by someone who wants to set the score
    public void CallSetScore(int teamID, int score)
    {
        this.photonView.RPC("TeamScoreUp", PhotonTargets.All, teamID, score);
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (a)
        {
            stream.SendNext(Player1Score);
            stream.SendNext(Player2Score);
        }
        else
        {
            Player1Score = (int)stream.ReceiveNext();
            Player2Score = (int)stream.ReceiveNext();
        }
    }
    [PunRPC]
    public void TeamScoreUp(int teamID, int score)
    {
        if (teamID == 1)
        {
            Player1Score += score;
        }
        else
        {
            Player2Score += score;
        }
    }
}
