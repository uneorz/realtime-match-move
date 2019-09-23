using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class audioScript : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    List<LyricData> lyricDataList = new List<LyricData>();
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load("Audio/tr01") as AudioClip;
        audioSource.Play();

        lyricDataList.Add(new LyricData("ミッドナイトリバティ", 4.7f));
        lyricDataList.Add(new LyricData("Pizuya's Cell", 10.6f));
        lyricDataList.Add(new LyricData("That's a Secret", 17.6f));
        lyricDataList.Add(new LyricData("秘密の裏で廻る世界", 18.5f));
        lyricDataList.Add(new LyricData("世迷言が噂になる", 20.1f));
        lyricDataList.Add(new LyricData("虚言が運命に生まれ変わる", 21.7f));
        lyricDataList.Add(new LyricData("その瞬間を見逃してもキミはキミのまま", 23.2f));
        lyricDataList.Add(new LyricData("だとしても", 25.8f));
        lyricDataList.Add(new LyricData("Choiceの権利とDoneの義務は", 26.7f));
        lyricDataList.Add(new LyricData("引き出しにしまったまんま", 28.2f));
        lyricDataList.Add(new LyricData("今日も夜が始まる", 30.2f));
        lyricDataList.Add(new LyricData("お前が決める番", 31.6f));
        lyricDataList.Add(new LyricData("なのに他人事でいるつもりかい？", 32.5f));

        foreach (LyricData lyricData in lyricDataList)
        {
            this.UpdateAsObservable()
                .First(x => audioSource.time > lyricData.time)
                .Subscribe(x => this.GetComponent<lyricScript>().Putlyric(lyricData.text));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public class LyricData
    {
        public string text;
        public float time;

        public LyricData(string text, float time)
        {
            this.text = text;
            this.time = time;
        }
    }

}
