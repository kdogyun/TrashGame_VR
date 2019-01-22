using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : Photon.MonoBehaviour {

    public int Player1Score = 0;
    public int Player2Score = 0;
    public bool a;

    //Called by someone who wants to set the score
    public void CallSetScore(int teamID, int score)
    {
        this.photonView.RPC("TeamScoreUp", PhotonTargets.All, teamID, score);
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
