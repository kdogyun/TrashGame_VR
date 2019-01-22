using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NetworkController : MonoBehaviour {

    public GameObject Player;
    public GameObject ScoreManager;
    //public GameObject headPrefab;
    //public GameObject leftHandPrefab;
    //public GameObject rightHandPrefab;
    //public GameObject colaPrefab;
    public Text count1Text,count2Text;
    public Text LoadingText;
    public Text ResaltText;
    public ScoreManager Sm;
    float time1 = 7.0f;
    public float R_time = 180.0f;
    public float Loading_time = 3.0f;
    public int TimeToInt;
    public Text timeText;

    string _room = "testsssssssssssssssssssssss";

    // Use this for initialization
    void Start() {
        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    void OnJoinedLobby()
    {
        Debug.Log("joined lobby");

        RoomOptions roomOptions = new RoomOptions() { };
        PhotonNetwork.JoinOrCreateRoom(_room, roomOptions, TypedLobby.Default);
    }

    void OnCreatedRoom()
    {
        PhotonNetwork.Instantiate("Cola Can", new Vector3(1.838f, 2.464f, 4.842f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("toothpaste_prefab", new Vector3(5.34f, 3.13f, 2.309f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Book7", new Vector3(5.916f, 3.371f, 2.032f), Quaternion.Euler(0, 270, 180), 0);
        PhotonNetwork.Instantiate("Book1", new Vector3(3.478841f, 1.703f, 5.57f), Quaternion.Euler(0, 0, 90), 0);
        PhotonNetwork.Instantiate("Candle_Small", new Vector3(-2.92f, 2.330405f, 4.031242f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("GiftBox_Cylinder_TypeA", new Vector3(4.52f, 1.676f, 6.86f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("ChristmasSock", new Vector3(-0.12f, 1.72f, 7.74f), Quaternion.Euler(90, 0, 0), 0) ;
     //   PhotonNetwork.Instantiate("RubberBall1", new Vector3(3.483f, 2.703f, 9.059f), Quaternion.identity, 0);
     //   PhotonNetwork.Instantiate("BeachBat1", new Vector3(3.483f, 2.703f, 9.059f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("SprayBottle_Prefab", new Vector3(-1.24f, 1.670782f, 3.29f), Quaternion.Euler(90, 27, 0), 0);
        PhotonNetwork.Instantiate("Bottle_Water", new Vector3(1.87f, 1.706f, 1.676f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Mozzarella_prefab", new Vector3(-0.654f, 3.412f, 1.94f), Quaternion.Euler(270, 0, 0), 0);
        PhotonNetwork.Instantiate("milk_prefab", new Vector3(-0.106f, 3.386981f, 1.666f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Chips_Red", new Vector3(6.118f, 2.869f, 5.635f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Can_Red", new Vector3(5.06f, 3.144f, 2.138f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Bread_Prefab", new Vector3(0.2038479f, 3.386982f, 1.695f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Paperbag_prefab", new Vector3(6.298f, 2.873f, 5.788f), Quaternion.Euler(0, 90, 90), 0);
        PhotonNetwork.Instantiate("Paper_prefab", new Vector3(-3.38f, 1.741f, 8.33f), Quaternion.Euler(0, 90, 0), 0);
        PhotonNetwork.Instantiate("Soju_prefab", new Vector3(0.142f, 2.372f, 5.49f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Susemi_prefab", new Vector3(-0.9569753f, 4f, 1.331341f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Papercup_prefab", new Vector3(0.29f, 2.269f, 5.12f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("Speaker_prefab", new Vector3(-2.78f, 2.35f, 4.721f), Quaternion.Euler(0, 180, 0), 0);
        PhotonNetwork.Instantiate("Receipt_prefab", new Vector3(5.224f, 3.163f, 4.225f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("creditcard_prefab", new Vector3(5.17f, 3.147382f, 3.96f), Quaternion.identity, 0);
        PhotonNetwork.Instantiate("CD_prefab", new Vector3(5.55f, 3.16f, 4.42f), Quaternion.identity, 0);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Avatar", ViveManager.Instance.head.transform.position, ViveManager.Instance.head.transform.rotation, 0);
        PhotonNetwork.Instantiate("leftHand", ViveManager.Instance.leftHand.transform.position, ViveManager.Instance.leftHand.transform.rotation, 0);
        PhotonNetwork.Instantiate("rightHand", ViveManager.Instance.rightHand.transform.position, ViveManager.Instance.rightHand.transform.rotation, 0);
    }



    // Update is called once per frame
    void Update () {
        if(PhotonNetwork.playerList.Length >= 1)
        {
            if(Loading_time <= 0.0f)
            {
                if(R_time == 180)
                {
                    playSound("[CameraRig]");
                }
                LoadingText.text = "";
                if(R_time > 0)
                {

                    R_time -= Time.deltaTime;
                    TimeToInt = (int)R_time;
                    count1Text.text = ScoreManager.GetComponent<ScoreManager>().Player1Score.ToString();
                    count2Text.text = ScoreManager.GetComponent<ScoreManager>().Player2Score.ToString();
                    timeText.text = (TimeToInt / 60).ToString() + " : " + (TimeToInt % 60).ToString();
                    if (TimeToInt == 15)
                    {
                        //8-9에서 텐 이 나옴
                        stopSound("[CameraRig]");
                        playSound("CountDown");
                       
                    }
                }
                else if (R_time <= 0)
                {
                    time1 -= Time.deltaTime;
                    R_time = 0;
                    timeText.text = "";
                  //  count1Text.text = "";
                  //  count2Text.text = "";
                    if (Sm.Player2Score > Sm.Player1Score)
                    {
                        win();
                        
                    }
                    else if(Sm.Player1Score == Sm.Player2Score)
                    {
                        drew();
                    }
                    else
                    {
                        lose();
                    }
                }

            }
            else
            {
                if (Loading_time == 3)
                {
                    playSound("3seconds");

                    PhotonNetwork.Instantiate("Twinkle", new Vector3(1.838f, 2.464f, 4.842f), Quaternion.Euler(-90,0,0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(5.34f, 3.13f, 2.309f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(5.916f, 3.371f, 2.032f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(3.478841f, 1.703f, 5.57f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-2.92f, 2.330405f, 4.031242f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(4.52f, 1.676f, 6.86f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-0.12f, 1.72f, 7.74f), Quaternion.Euler(-90, 0, 0), 0);
                    //   PhotonNetwork.Instantiate("RubberBall1", new Vector3(3.483f, 2.703f, 9.059f), Quaternion.identity, 0);
                    //   PhotonNetwork.Instantiate("BeachBat1", new Vector3(3.483f, 2.703f, 9.059f), Quaternion.identity, 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-1.24f, 1.670782f, 3.29f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(1.87f, 1.706f, 1.676f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-0.654f, 3.412f, 1.94f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-0.106f, 3.386981f, 1.666f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(6.118f, 2.869f, 5.635f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(5.06f, 3.144f, 2.138f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(0.2038479f, 3.386982f, 1.695f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(6.298f, 2.873f, 5.788f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-3.38f, 1.741f, 8.33f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(0.142f, 2.372f, 5.49f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-0.9569753f, 4f, 1.331341f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(0.29f, 2.269f, 5.12f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(-2.78f, 2.35f, 4.721f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(5.224f, 3.163f, 4.225f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(5.17f, 3.147382f, 3.96f), Quaternion.Euler(-90, 0, 0), 0);
                    PhotonNetwork.Instantiate("Twinkle", new Vector3(5.55f, 3.16f, 4.42f), Quaternion.Euler(-90, 0, 0), 0);
                }
                    Loading_time -= Time.deltaTime;
                LoadingText.text = ((int)Loading_time).ToString();
            }
        }
    }

    void win()
    {
        if (time1 == 5.0f)
            playSound("Winner");
        if (time1 < 5.0f)
        {
            count1Text.text = "";
            count2Text.text = "";
            ResaltText.text = "You Win!!";
            playSound("Winner");
        }
         if (time1 <= 0)
        {
            SceneManager.LoadScene("Score");
        }
    }
    void drew()
    {
        if(time1==5.0f)
            playSound("Winner");
        if (time1 < 5.0f)
        {
            count1Text.text = "";
            count2Text.text = "";
            ResaltText.text = "Drew";

        }
        if (time1 <= 0)
        {
            SceneManager.LoadScene("Score");
        }
    }
    void lose()
    {
        if (time1 == 5.0f)
            playSound("Winner");
        if (time1 < 5.0f)
        {
            count1Text.text = "";
            count2Text.text = "";
            ResaltText.text = "You Lose";
            playSound("Losser");
        }
        if (time1 <= 0)
        {
            SceneManager.LoadScene("Score");
        }
    }

    void playSound(string snd)
    {
        Debug.Log(snd);
        GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }

    void stopSound(string snd)
    {
        GameObject.Find(snd).GetComponent<AudioSource>().Stop();
    }

}