using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//초기화-(물리엔진- 게임로직) 프레임 -해체

//
public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable() //킬 때마다 활성화
    {
        Debug.Log("플레이어가 로그인 하였습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
        
    }
    void FixedUpdate() //물리 연산 관련 로직
    {
        Debug.Log("이동");
    }

    void Update()
    {
        Debug.Log("몬스타 사냥!");
    }
    void LateUpdate()  //모든 업데이트 로직이 끝난 후에 실행
    {
        Debug.Log("경험치 획득.");
    }

    void OnDisable() //오브젝트 비활성화
    {
        Debug.Log("플레이어가 로그아웃 하였습니다.");
    }
    void OnDestroy() //게임오브젝트가 삭제될 때 //스크립트 해제하였을때
    {
        Debug.Log("플레이어 데이터가 해제하였습니다.");
    }





}
