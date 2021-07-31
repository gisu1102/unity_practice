using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rigid; //선언 물리현상은 FixedUpdate에 선언
    void Start()
    {
        rigid = GetComponent<Rigidbody>();  //자신의 <T>타입 컴포넌트를 가져옴

        //속도 올리기 velocity -Vector3
        /*rigid.velocity = new Vector3(2,4,3);

        //힘으로 밀기
        rigid.AddForce(Vector3.up * 5,ForceMode.Impulse); //캐릭터 점프할때이거 씀
                                                          // AddForce 방향으로 힘 추가

        //회전력
        rigid.AddTorque(Vector3.back); //vector 값을 축으로 함
        */
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }
        Vector3 Vec = new Vector3(Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical"));
        rigid.AddForce(Vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other) //콜라이더가 계속 충돌하고있을 때 호출
    {
        if(other.name == "Cube")
            rigid.AddForce(Vector3.up *2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

}

/* Summary
  v
 */