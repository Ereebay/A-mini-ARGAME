using UnityEngine;
using System.Collections;

/// <summary>
/// 控制UI显示消失脚本
/// </summary>
public class SetCanActive : MonoBehaviour {
		/// <summary>
		/// UI 
		/// </summary>
	public GameObject can;
	// Use this for initialization
	void Start () {
				
				setActive();
	}
	void FixedUpdate()
	{
				//没渲染帧执行

				setActive();
	}
		//说明，高通ar控制物体消失出现时通过MeshRenderer来实现的，但是UI并不存在这一个组件
		//所以用这个脚本来控制UI的消失和出现
		//修改UI的Active为本物体的Meshrenderer的Enabled就可以控制UI的出现消失了
		//任何没有meshrenderer组件的物体都能用这个脚本控制
		private void setActive()
		{
				can.SetActive (this.transform.GetComponent<MeshRenderer> ().enabled);
		}
}
