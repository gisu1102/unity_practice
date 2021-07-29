using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Mouse : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        //Input //게임 내 입력을 관리하는 클래스 // 
        
        if (Input.anyKeyDown) //아무 입력을 최초로 받을 때 true bool임
            Debug.Log("플레이어가 아무 키를 눌렀습니다");

        if (Input.anyKey)
            Debug.Log("플레이어가 아무키를 누르고있습니다.");

        //Down-눌렀을 때  Stay-누르고 있을 때   up-땔 때
        if (Input.GetKeyDown(KeyCode.Return))//Return = 엔터
            Debug.Log("아이템 구매.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동 멈춤.");


        //마우스
        if (Input.GetMouseButtonDown(0))// 0=마우스 왼쪽 1=마우스 오른쪽
            Debug.Log("미사일 발사.");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 기모으는 중");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사.");

        //점프
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!!!");




    }
}
