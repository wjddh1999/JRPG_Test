using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharicType
{
    The_Destruction = 0,//파멸
    The_Hunt,           //수렵
    The_Erudition,      //지식
    The_Harmony,        //화합
    The_Nihility,       //공허
    The_Preservation,   //보존
    The_Abundance,      //풍요
    The_Remembrance,    //기억

    Count
}

public class Chr_Stat   
{
    public CharicType m_CharType;   
    public int m_CharID = 0;    
    public string m_Name = "";      
    //public string m_RscFile = "";   
    public float m_MaxHp = 0.0f;         
    public float m_Attack = 0.0f;        
    public float m_Def = 0.0f;  
    public float m_Speed = 0.0f;
    public int Aggresive = 0;

    public virtual Char_Table MyAddComponent(GameObject a_ParentGObj)
    {
        return null;
    }
}


public class Char_Table : MonoBehaviour
{
    [HideInInspector] public Chr_Stat m_ChrStat = null;

    [HideInInspector] public float m_CurHp = 0;        
    [HideInInspector] public float m_CurAtt = 0;     
    [HideInInspector] public float m_CurDef = 0;     
    [HideInInspector] public float m_CurSpeed = 0;     
    [HideInInspector] public int m_CurAgg = 0;     

    InGameMgr m_RefGameMgr = null;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        m_RefGameMgr = FindFirstObjectByType<InGameMgr>();

        if (m_ChrStat == null)
            return;

        //GameObject a_ChrSprite = Resources.Load(m_ChrStat.m_RscFile) as GameObject; //<--- ���ҽ� �ε�
        // if (a_ChrSprite != null)
        // {
        //     GameObject a_Clone = Instantiate(a_ChrSprite); //���� �� Hero GameObject �� ���� ��������Ʈ ����
        //     a_Clone.transform.SetParent(this.transform, false); //Hero �ؿ� ���ϵ�� WizRenderer ���̱�...
        // }

        //--- ����ġ ���� ������ ����
        m_CurHp = m_ChrStat.m_MaxHp;
        m_CurAtt = m_ChrStat.m_Attack;
        m_CurDef = m_ChrStat.m_Def;
        m_CurSpeed = m_ChrStat.m_Speed;
        m_CurAgg = m_ChrStat.Aggresive;
        //--- ����ġ ���� ������ ����

    }//protected virtual void Start()

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    public virtual void Attack()
    {
        
    }

    public virtual void UseSkill()
    {
        
    }

    protected void LogMsg(string msg)
    {
        if (m_RefGameMgr != null)
            m_RefGameMgr.LogMsg(msg);
    }
}
