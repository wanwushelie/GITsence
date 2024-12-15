using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI; // 如果您使用按钮来触发动画


public class TimelineController : MonoBehaviour
{
    public PlayableDirector director; // 引用PlayableDirector以播放动画
    public Button playAnimationButton; // 引用按钮来播放动画

    private bool m_AlreadyTriggered; // 标记动画是否已经播放过

    void Start()
    {
        // 给按钮添加点击事件
        playAnimationButton.onClick.AddListener(OnPlayAnimationButtonClicked);
    }

    private void OnPlayAnimationButtonClicked()
    {
        if (m_AlreadyTriggered)
            return;

        director.Play(); // 播放动画
        //m_AlreadyTriggered = true; // 设置标记为已播放

    }

}