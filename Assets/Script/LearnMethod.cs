using UnityEngine;

public class LearnMethond : MonoBehaviour
{
    //方法語法
    //傳回類型 方法自訂名稱 () { 方法內容 }
    //無傳回 void
    //方法名稱 Unity 習慣用大寫開頭
    private void Test()
    {
        //輸出(輸出訊息);
        print("Hellow World");
    }

    //自訂方法
    //需要呼叫才會執行
    //播放遊戲後會執行一次
    //初始化設定：初始金額、三條命等

    private void Start()
    {
        Test();
        PrintColorText();
    }
    private void PrintColorText()
    {
        print("<color=yellow>黃色訊息</color>");
    }
}





