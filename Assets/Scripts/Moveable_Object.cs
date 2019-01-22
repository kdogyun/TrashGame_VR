using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Moveable_Object : MonoBehaviour
{
    public float MoveSpeed;
    public GameObject ScoreManager;
    public SteamVR_Action_Vibration sva;
    public Feedback_Script pl;
    public int Team=1;
    
   // public ControllerGrabObject_L ConL,ConR;

    // Start is called before the first frame update
    void Start()
    {
        Team = 2;
        ScoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
        pl = GameObject.FindGameObjectWithTag("Error").GetComponent<Feedback_Script>();
    }

    void playSound(string snd)
    {
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        playSound("TrashSound");
        if (this.GetComponent<PhotonView>().ownerId == PhotonNetwork.player.ID)
        {
            if (this.gameObject.tag.Contains("_Plastic"))
            {
                if (collision.gameObject.tag == "TrashBox_Plastic")
                {
                    playSound("Correct");
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, 1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
                else if (collision.gameObject.tag.Contains("TrashBox"))
                {
                    playSound("Wrong");
                    pl.Error.Add(this.gameObject.tag);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.LeftHand);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.RightHand);
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, -1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
            }

            else if (this.gameObject.tag.Contains("_Paper"))
            {
                if (collision.gameObject.tag == "TrashBox_Paper")
                {
                    playSound("Correct");
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, 1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
                else if (collision.gameObject.tag.Contains("TrashBox"))
                {
                    playSound("Wrong");
                    pl.Error.Add(this.gameObject.tag);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.LeftHand);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.RightHand);
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, -1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
            }

            else if (this.gameObject.tag.Contains("_Mettal"))
            {
                if (collision.gameObject.tag == "TrashBox_Mettal")
                {
                    playSound("Correct");
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, 1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
                else if (collision.gameObject.tag.Contains("TrashBox"))
                {
                    playSound("Wrong");
                    pl.Error.Add(this.gameObject.tag);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.LeftHand);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.RightHand);
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, -1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
            }

            else if (this.gameObject.tag.Contains("_General"))
            {
                if (collision.gameObject.tag == "TrashBox_General")
                {
                    playSound("Correct");
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, 1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
                else if (collision.gameObject.tag.Contains("TrashBox"))
                {
                    playSound("Wrong");
                    pl.Error.Add(this.gameObject.tag);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.LeftHand);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.RightHand);
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team,-1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
            }

            else if (this.gameObject.tag.Contains("_Others"))
            {
                if (collision.gameObject.tag == "TrashBox_Others")
                {
                    playSound("Correct");
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, 1);
                    PhotonNetwork.Destroy(this.gameObject);
                }
                else if (collision.gameObject.tag.Contains("TrashBox"))
                {
                    playSound("Wrong");
                    pl.Error.Add(this.gameObject.tag);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.LeftHand);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.RightHand);
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, -1);
                    PhotonNetwork.Destroy(this.gameObject);

                }
            }

            else if (this.gameObject.tag.Contains("_Food"))
            {
                if (collision.gameObject.tag == "TrashBox_Food")
                {
                    playSound("Correct");
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, 1);
                    PhotonNetwork.Destroy(this.gameObject);
                }
                else if (collision.gameObject.tag.Contains("TrashBox"))
                {
                    playSound("Wrong");
                    pl.Error.Add(this.gameObject.tag);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.LeftHand);
                    sva.Execute(0, 0.5f, 100, 3000, SteamVR_Input_Sources.RightHand);
                    ScoreManager.GetComponent<ScoreManager>().CallSetScore(Team, -1);
                    PhotonNetwork.Destroy(this.gameObject);

                }

            }

        }
    }
     
}


