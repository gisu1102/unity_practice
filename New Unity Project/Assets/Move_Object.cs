using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 target = new Vector3(20, 2, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1.MoveTowards (단순 등속 이동)
        /*
        transform.position =
            Vector3.MoveTowards(
                transform.position,
                target,
                1f);      //매개변수 (현재위치,목표위치,속도)로 구성 함수
        */

        //2.SmoothDamp (미끄러지듯이 감속 이동)
        Vector3 velo = Vector3.zero;
        /*
        transform.position =
            Vector3.SmoothDamp(transform.position,
                target,
                ref velo, //참조 접근 -> 실시간으로 바뀌는 값 적용 가능 ; reference 
                0.1f
                );  //마지막 매개변수에 반비례하여 속도증가
        */

        //3.Lerp (선형 보간 이동), SmoothDamp 보다 감속시간이 김
        /*
        transform.position =
        Vector3.Lerp(
            transform.position,
            target,
            0.1f
            );  //movetowards 랑 같은 매커니즘
        */

        //4. SLerp (구면 선형 보간 이동) ,호를 그리며 이동 ;포물선 이동
        
         transform.position =
            Vector3.Slerp(
                transform.position,
                target,
                0.01f); 
        
        

        //Time.deltaTime - 이전 프레임 완료까지 걸린 시간 조절 
        //프레임값이 크면 값이 작고 프레임값이 작으면 값이 큼
        //컴퓨터 성능에 따라 온라인상에서 프레임이 다르기 때문에 조절 필요
        //Translate :벡터에 곱하기
        //transform.Translate(Vec*Time.deltaTime)
        //Vector함수 : 시간 매개변수에 곱하기
        //Vector3.Lerp(vec1,vec2,T*Time.deltaTime)
        

    }
}
