using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�ʱ�ȭ-(��������- ���ӷ���) ������ -��ü


public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void OnEnable() //ų ������ Ȱ��ȭ
    {
        Debug.Log("�÷��̾ �α��� �Ͽ����ϴ�.");
    }

    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
        
    }
    void FixedUpdate() //���� ���� ���� ����
    {
        Debug.Log("�̵�");
    }

    void Update()
    {
        Debug.Log("��Ÿ ���!");
    }
    void LateUpdate()  //��� ������Ʈ ������ ���� �Ŀ� ����
    {
        Debug.Log("����ġ ȹ��.");
    }

    void OnDisable() //������Ʈ ��Ȱ��ȭ
    {
        Debug.Log("�÷��̾ �α׾ƿ� �Ͽ����ϴ�.");
    }
    void OnDestroy() //���ӿ�����Ʈ�� ������ �� //��ũ��Ʈ �����Ͽ�����
    {
        Debug.Log("�÷��̾� �����Ͱ� �����Ͽ����ϴ�.");
    }





}
