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
        //1.MoveTowards (�ܼ� ��� �̵�)
        /*
        transform.position =
            Vector3.MoveTowards(
                transform.position,
                target,
                1f);      //�Ű����� (������ġ,��ǥ��ġ,�ӵ�)�� ���� �Լ�
        */

        //2.SmoothDamp (�̲��������� ���� �̵�)
        Vector3 velo = Vector3.zero;
        /*
        transform.position =
            Vector3.SmoothDamp(transform.position,
                target,
                ref velo, //���� ���� -> �ǽð����� �ٲ�� �� ���� ���� ; reference 
                0.1f
                );  //������ �Ű������� �ݺ���Ͽ� �ӵ�����
        */

        //3.Lerp (���� ���� �̵�), SmoothDamp ���� ���ӽð��� ��
        /*
        transform.position =
        Vector3.Lerp(
            transform.position,
            target,
            0.1f
            );  //movetowards �� ���� ��Ŀ����
        */

        //4. SLerp (���� ���� ���� �̵�) ,ȣ�� �׸��� �̵� ;������ �̵�
        /*
         transform.position =
            Vector3.Slerp(
                transform.position,
                target,
                0.01f); 
        
        */

        //Time.deltaTime - ���� ������ �Ϸ���� �ɸ� �ð� ���� 
        //�����Ӱ��� ũ�� ���� �۰� �����Ӱ��� ������ ���� ŭ
        //��ǻ�� ���ɿ� ���� �¶��λ󿡼� �������� �ٸ��� ������ ���� �ʿ�
        //Translate :���Ϳ� ���ϱ�
        //transform.Translate(Vec*Time.deltaTime)
        //Vector�Լ� : �ð� �Ű������� ���ϱ�
        //Vector3.Lerp(vec1,vec2,T*Time.deltaTime)
        

    }
}
