using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameMgr : MonoBehaviour
{
    public Text TxtLogMsg;

    List<string> m_MsgList = new List<string>();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LogMsg(string msg)
    {
        Debug.Log(msg);
        m_MsgList.Add(msg);
        if (8 < m_MsgList.Count)
            m_MsgList.RemoveAt(0);

        TxtLogMsg.text = "";
        for (int i = 0; i < m_MsgList.Count; i++)
        {
            TxtLogMsg.text += m_MsgList[i];
            TxtLogMsg.text += "\n";
        }
    }//public void LogMsg(string msg)
}
