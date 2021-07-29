using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///키보드 마우스로 이동시키기
/// </summary>


public class Key_Mouse : MonoBehaviour
{
  
    // Update is called once per frame
    void Start()
    {
        //Input //게임 내 입력을 관리하는 클래스 // 
        /*
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

        //횡 이동  종 이동

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동중..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동중..." + Input.GetAxisRaw("Vertical"));
        }
        */


        //오브젝트는 변수 transform을 항상 가지고 있음 (초기화 완료된 상태)
        //translate 벡터 값을 현재 값에 더하는 함수
        //int number = 4; //스칼라 값
        Vector3 vec = new Vector3(5, 0, 0); //초기화  벡터 값 내가아는 수학벡터 맞음 ㅇㅇ

        transform.Translate(vec);


        
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),    //중간값
            Input.GetAxisRaw("Vertical"),   //단위가 1
            0); //초기화  벡터 값 내가아는 수학벡터 맞음 ㅇㅇ

        transform.Translate(vec);
    }








}
