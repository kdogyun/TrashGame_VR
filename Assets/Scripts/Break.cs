using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {
    public Collider[] colliders;                           // 자식오브젝트에 순차적으로 컴퍼넌트를 값을 변경하기 위한 배열

    void OnTriggerEnter(Collider col)      //부모로 만든 빈 오브젝트의 Collider를 건드리면 (누가 건드렸는지 확인)
    {
        if (col.tag == "GameController")                 // 만약 "Weapon" 태그로 지정된 무기가 Collider를 건드리면
        {
            colliders = gameObject.GetComponentsInChildren<Collider>();
            foreach (Collider item in colliders)
            {
                item.GetComponent<Rigidbody>().constraints = (RigidbodyConstraints)0;     //rigidbody.constraints 체크 해제
            }
        }
    }
}
