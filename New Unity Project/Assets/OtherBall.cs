using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;

    }

    private void OnCollisionEnter(Collision collision) //물리적충돌이 시작할 때 호줄되는 함수
                                                       //collision 충돌 관련 클래스
    {
       if(collision.gameObject.name =="Sphere")
            mat.color = new Color(0, 0, 0);

    }
    /*
    private void OnCollisionStay(Collision collision) //하는중
    {
        
    }
    */
    private void OnCollisionExit(Collision collision) //끝날 때
    {
       
        if(collision.gameObject.name =="Sphere")
            
            mat.color = new Color(1, 1, 1);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
