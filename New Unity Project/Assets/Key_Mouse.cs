using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///Ű���� ���콺�� �̵���Ű��
/// </summary>


public class Key_Mouse : MonoBehaviour
{
  
    // Update is called once per frame
    void Start()
    {
        //Input //���� �� �Է��� �����ϴ� Ŭ���� // 
        /*
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

        //Ⱦ �̵�  �� �̵�

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵���..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵���..." + Input.GetAxisRaw("Vertical"));
        }
        */


        //������Ʈ�� ���� transform�� �׻� ������ ���� (�ʱ�ȭ �Ϸ�� ����)
        //translate ���� ���� ���� ���� ���ϴ� �Լ�
        //int number = 4; //��Į�� ��
        Vector3 vec = new Vector3(5, 0, 0); //�ʱ�ȭ  ���� �� �����ƴ� ���к��� ���� ����

        transform.Translate(vec);


        
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),    //�߰���
            Input.GetAxisRaw("Vertical"),   //������ 1
            0); //�ʱ�ȭ  ���� �� �����ƴ� ���к��� ���� ����

        transform.Translate(vec);
    }








}
