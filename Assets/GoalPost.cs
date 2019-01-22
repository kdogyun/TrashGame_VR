using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GoalPost : MonoBehaviour
{

    public Team[] teams;


    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter 자체는 모든 클라이언트에서 실행되지만
        // 효과를 적용하는 아래 부분은 방장에서만 실행되므로
        // 플레이어 수만큼 점수를 증가하는 처리가 중복처리되는 현상이 막아짐

        // 여기는 골대에 골이 들어갔을때의 "시각적인 처리" == 실제로 수치를 변경하지 않는 처리


        // 지금 이 코드를 실행하고 있는 컴퓨터가 방장인가?
        if(PhotonNetwork.isMasterClient)
        {
            // 여기에 점수 증가처리
            
            // team에 따라서 점수를 증기시키는 코드
        }
    }
}
