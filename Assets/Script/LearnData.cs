// 2022.05.16 綿羊
/* 多行註解
 * 藍色-保留字
 * 白色-名稱
 * 綠色-資料類別
 */
using UnityEngine;

// 修飾詞 類別(藍圖) 類別名稱 繼承(物件導向設計 OOP三大原則)
public class LearnData : MonoBehaviour
{
    // LearnData 類別成員區域

    /* 儲存資料方式：
       欄位 field
       儲存各種資料
       欄位語法
       資料類型 欄位自訂名稱 指定 值 結束符號
       指定 值 可以省略，會以預設值，數值預設值 0，字串空、布林值 flase 沒有
       定義一筆整數資料 名稱叫做 hp
     */
    // 資料類型：四大基本類型
    // 整數：保存正負沒有小數點的資料 int
    // 浮點數：保存正負有小數點的資料 float
    // 字串：保存文字資訊 string
    // 布林值：保存有、沒有 bool

    int hp;
    int lv = 123;
    // 浮點數必須加上 f 後綴、大小 F 皆可
    float exp = 0.003f;
    // 字串必須使用雙引號
    string PlayersName = "LanSheep";
    // true 有、flase 沒有
    bool hasCureSkill = true;
    // 書籍參考：Clean Code 無瑕的程式
}
  // 非LearnData 類別成員區域