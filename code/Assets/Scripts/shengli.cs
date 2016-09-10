using UnityEngine;
using System.Collections;

public class shengli : MonoBehaviour {
		//窗口active修改的时候自动调用
		public void  OnEnable()
		{
				//这个窗口是否显示
				if (this.gameObject.activeSelf) {
						//延时执行，第一个参数删除为方法名，第二个参数为时间
						Invoke ("tz",5f);

				}
		}
		/// <summary>
		/// 跳转方法
		/// </summary>
		private void tz()
		{
				Application.LoadLevel ("SceneEnd");
		}
}
