using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Mouse : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        //Input //���� �� �Է��� �����ϴ� Ŭ���� // 
        
        if (Input.anyKeyDown) //�ƹ� �Է��� ���ʷ� ���� �� true bool��
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�");

        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ�Ű�� �������ֽ��ϴ�.");

        //Down-������ ��  Stay-������ ���� ��   up-�� ��
        if (Input.GetKeyDown(KeyCode.Return))//Return = ����
            Debug.Log("������ ����.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵���");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵� ����.");


        //���콺
        if (Input.GetMouseButtonDown(0))// 0=���콺 ���� 1=���콺 ������
            Debug.Log("�̻��� �߻�.");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������� ��");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�.");

        //����
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!!!");




    }
}
