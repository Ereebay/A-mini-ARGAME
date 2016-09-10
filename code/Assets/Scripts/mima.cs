using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
/// <summary>
///输入密码控制器脚本
/// </summary>
public class mima : MonoBehaviour {
		/// <summary>
		/// 挡住*号的图片，输入密码时消失
		/// </summary>
	public GameObject[] rwaimage;
		/// <summary>
		/// 保存密码字符串
		/// </summary>
	private string mm;
		/// <summary>
		/// 保存当前正在输入密码的链表
		/// 使用链表方便操作
		/// </summary>
	public List<int> mmlist=new List<int>();
		/// <summary>
		/// 输入正确时出现的图片
		/// </summary>
	public GameObject shenliRaw;
		/// <summary>
		/// 输入错误时出现的图片
		/// </summary>
	public GameObject DieRaw;
	// Use this for initialization
	void Start () {
				//初始化*
		xx ();
	}
	/// <summary>
	/// 死亡时出现窗口中的按钮
	/// </summary>
	public void DieButtonOnClick()
	{
				//清空链表
				mmlist.Clear ();
				//死亡窗口消失
				DieRaw.SetActive (false);
				//刷新显示
				xx ();
	}
		/// <summary>
		/// 点击了数字键是调用这个方法
		/// </summary>
		/// <param name="a">The alpha component.</param>
	public void Onbutton(int a)
	{
				//小于4个数字的时候加入链表
		if (mmlist.Count < 4) {
			mmlist.Add (a);
		}
				//刷新*
		xx ();
				///临时保存密码的字符串
		string aaa="";

		Debug.Log (aaa);
				//当密码为四位数的时候
		if (mmlist.Count >= 4) {
						///枚举链表里的数字，放到临时字符串中
						foreach (var item in mmlist) {
								aaa += item.ToString();
						}
            //判断密码是否正确
            if (aaa == "0000")
            {
                //跳转场景
                //胜利窗口出现
                shenliRaw.gameObject.SetActive(true);
            }
            else
            {
                //失败窗口出现
                DieRaw.SetActive(true);
            }
		}
	}
		//当输入的不是数字，调用此方法
	public void Onbutton(string a)
	{
				//如果按下的是减按钮
				if (a == "jian") {
						//清除链表最后一位
						mmlist.RemoveAt (mmlist.Count - 1);
	


						//输出一下密码
						string aaa = "";
						foreach (var item in mmlist) {
								aaa += item.ToString ();
						}
						Debug.Log (aaa);
						//刷新显示
						xx ();
				}
	}
		/// <summary>
		/// 显示，输入的时候刷新一下
		/// </summary>
	private void xx()
	{
				//先所有都显示，挡住*号
		for (int i = 0; i < 4; i++) {
			rwaimage [i].SetActive (true);
		}
				//然后根据输入的个数隐藏，露出*号
		for (int i = 0; i < mmlist.Count; i++) {
			rwaimage [i].SetActive (false);
		}
	}

	public void Onbutton0()
	{
		Onbutton (0);
	}
	public void Onbutton1()
	{
		Onbutton (1);
	}
	public void Onbutton2()
	{
		Onbutton (2);
	}
	public void Onbutton3()
	{
		Onbutton (3);
	}
	public void Onbutton4()
	{
		Onbutton (4);
	}
	public void Onbutton5()
	{
		Onbutton (5);
	}
	public void Onbutton6()
	{
		Onbutton (6);
	}
	public void Onbutton7()
	{
		Onbutton (7);
	}
	public void Onbutton8()
	{
		Onbutton (8);
	}
	public void Onbutton9()
	{
		Onbutton (9);
	}
	public void Onbuttonjian()
	{
		Onbutton ("jian");
	}
}
