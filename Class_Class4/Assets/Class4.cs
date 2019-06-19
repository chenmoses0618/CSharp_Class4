using UnityEngine;

public class Class4 : MonoBehaviour
{
    #region 非陣列方式宣告
    public int A = 60;
    public int B = 70;
    public int C = 90;
    #endregion
    #region 陣列宣告方式範例
    //整數類型不指定初始值陣列
    public int[] scores;
    //指定初始陣列數,未指定初始值
    public float[] weights = new float[3];
    //public string[] names = new string[3];//宣告無初值陣列
    public string[] names = new string[] { "張珊","李思","王武"};//指定宣告文字陣列(包含資料型態)
    public bool[] mission = { true, true, false };//宣告陣列並指定內容(不包含資料型態)
    public Color[] colors = new Color[4];//宣告結構型態陣列
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        scores = new int[] { 60, 70, 90 };//動態指定陣列初始值
        //存取陣列資料-陣列名稱[索引值]
        Debug.Log("取得姓名陣列初始資料第一筆:"+names[0]);
        //寫入陣列資料,指定陣列[索引值]即可
        names[0] = "周六";
        Debug.Log("取得姓名陣列變更後資料第一筆:" + names[0]);
        Debug.Log("取得姓名陣列長度:" + names.LongLength);
        Debug.Log("取得分數陣列長度:" + scores.LongLength);
        Debug.Log("取得顏色陣列長度:" + colors.LongLength);
        //此時為引數
        sun(10, 7);
        //整數為實值型別,只將變數內容數值傳入函數,對既有變數值不影響
        ClearA(A);
        //陣列為參考型別,傳送變數位址,實際會傳送變數型別進行修改
        ClearScores(scores);
    }
    //此時a,b為參數  一個加總函數
    private void sun(int a, int b) {
        Debug.Log("總合為:"+(a+b));
    }
    private void ClearA(int getA)
    {
        getA = 0;
    }
        private void ClearScores(int[] getScores )
    {
        getScores[0] = 0;
        getScores[1] = 0;
        getScores[2] = 0;
    }
    
}
