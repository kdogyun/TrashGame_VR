using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Feedback_Script : MonoBehaviour {

    public List<string> Error = new List<string>();
    public Dictionary<string, string> feedback = new Dictionary<string, string>();
    public Dictionary<string, string> Tokorean = new Dictionary<string, string>();
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start()
    {
        feedback.Add("Can_Mettal", "캔류에 분리수거해주세요.");
        feedback.Add("Card_General", "일반쓰레기입니다.");
        feedback.Add("Recipt_General", "영수증은 종이류가 아닙니다. 일반쓰레기에 버려주세요.");
        feedback.Add("Toothpaste_General", "치약 튜브는 일반쓰레기입니다.");
        feedback.Add("GlassBottle_Others", "유리병은 기타에 버려주세요.");
        feedback.Add("Pesticide_Mettal", "내용물을 완전히 제거 후 금속류에 배출해주세요.");
        feedback.Add("Socks_Others", "폐의류는 의류 전용수거함에 넣어주세요.");
        feedback.Add("Glass_Others", "유리입니다.");
        feedback.Add("Doll_Others", "일반쓰레기입니다. 종량제 봉투에 버려주세요.  ");
        feedback.Add("Dress_Others", "의류입니다.");
        feedback.Add("Pet_Plastic", "플라스틱류에 배출해주세요.");
        feedback.Add("TV", "스티커를 부착해주세요.");
        feedback.Add("Chair", "스티커를 부착해주세요");
        feedback.Add("Coconut_General", "일반쓰레기입니다.");
        feedback.Add("Banana_Food", "음식물쓰레기입니다.");
        feedback.Add("Scrubber_General", "일반쓰레기입니다.");
        feedback.Add("Pringles_Others", "일반쓰레기에 버려주세요.");
        feedback.Add("Snack_Others", "기타(비닐류)에 분리수거해주세요.");
        feedback.Add("Detergent_Plastic", "플라스틱류에 분리수거해주세요.");
        feedback.Add("Milk_Paper", "종이팩류에 분리수거해주세요.");
        feedback.Add("Pot-Others", "유리입니다. 기타에 버려주세요.");
        feedback.Add("Bone_General", " 일반쓰레기입니다. 일반쓰레기에 버려주세요.");
        feedback.Add("Tumbler_Plastic", "플라스틱입니다. 플라스틱류에 버려주세요.");
        feedback.Add("Papercup_Paper", " 종이류에 배출해주세요.");
        feedback.Add("Newspaper_Paper", ": 종이류에 배출해주세요. ");
        feedback.Add("CD_General", "여러가지 복합성분이 결합되어 있습니다. 일반쓰레기에 버려주세요.");
        feedback.Add("Pencil_General", "일반쓰레기입니다. 종량제 봉투에 넣어주세요.");
        feedback.Add("Battery_Others", " 기타에 버려주세요. 건전지는 폐건지 수거함에 배출해주세요");
        feedback.Add("Speaker", " 폐전자제품이므로 기타입니다. 스티커를 부착해주세요.");
        feedback.Add("Paper_Paper", "종이류입니다. 종이류에 분리수거해주세요.");
        feedback.Add("Stand", "폐전자제품이므로 기타입니다. 스티커를 부착해주세요. ");
        feedback.Add("Candle_General", "양초는 일반쓰레기 입니다.");

        Tokorean.Add("Can_Mettal", "콜라캔");
        Tokorean.Add("Card_General", "신용카드");
        Tokorean.Add("Recipt_General", "영수증");
        Tokorean.Add("Toothpaste_General", "치약");
        Tokorean.Add("GlassBottle_Others", "유리병");
        Tokorean.Add("Pesticide_Mettal", "살충제");
        Tokorean.Add("Socks_Others", "양말");
        Tokorean.Add("Glass_Others", "거울");
        Tokorean.Add("Doll_Others", "인형");
        Tokorean.Add("Dress_Others", "의류");
        Tokorean.Add("Pet_Plastic", "페트병");
        Tokorean.Add("TV", "텔레비전");
        Tokorean.Add("Chair", "의자");
        Tokorean.Add("Coconut_General", "코코넛");
        Tokorean.Add("Banana_Food", "바나나껍질");
        Tokorean.Add("Scrubber_General", "수세미");
        Tokorean.Add("Pringles_Others", "프링글스");
        Tokorean.Add("Snack_Others", "과자봉지");
        Tokorean.Add("Detergent_Plastic", "세제통");
        Tokorean.Add("Milk_Paper", "우유팩");
        Tokorean.Add("Pot-Others", "그릇");
        Tokorean.Add("Bone_General", "뼈");
        Tokorean.Add("Tumbler_Plastic", "텀블러");
        Tokorean.Add("Papercup_Paper", "종이컵");
        Tokorean.Add("Newspaper_Paper", "신문");
        Tokorean.Add("CD_General", "CD");
        Tokorean.Add("Pencil_General", "연필");
        Tokorean.Add("Battery_Others", "배터리");
        Tokorean.Add("Speaker", "스피커");
        Tokorean.Add("Paper_Paper", "종이상자");
        Tokorean.Add("Stand", "스탠드");
        Tokorean.Add("Candle_General", "양초");
        
    }

}
