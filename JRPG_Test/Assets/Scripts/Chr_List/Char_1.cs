using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_1_Stat : Chr_Stat
{
    public Char_1_Stat(string a_CrName = "Char1")  //������ �����ε� �Լ�
    {
        m_CharType = CharicType.The_Hunt;
        m_Name = a_CrName;
        m_MaxHp = 4000.0f;
        m_Attack = 2000.0f;
        m_Def = 700.0f;
        m_Speed = 143;
        //m_Agg = 75;
    }

    //ĳ������ ���� ������ ������� ������ ���� �ٴϴ� ĳ���� ��ü�� �߰��Ϸ��� �� ��
    //Hero ���� ������Ʈ�� ���� ��Ű�� ���ϴ� Ŭ���� �߰� �Լ�
    public override Char_Table MyAddComponent(GameObject a_ParentGObj)
    {
        Char_Table a_RefHero = a_ParentGObj.AddComponent<Char_1>();
        a_RefHero.m_ChrStat = this;
        return a_RefHero;
    }
}

public class Char_1 : Char_Table
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();  //�θ��� Start() �Լ� ȣ�� (���� ���� �غ�)

        LogMsg($"{m_ChrStat.m_Name} : �ü� ���� ���� �غ�");
    }

    // Update is called once per frame
    protected override void Update()
    {

    }
}
