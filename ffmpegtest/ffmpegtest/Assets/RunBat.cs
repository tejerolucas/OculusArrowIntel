using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System;
using System.IO;

public class RunBat : MonoBehaviour {
	void Start(){
		Record ();
		Mersh ();
	}
	void Record () {
		try {
			UnityEngine.Debug.Log("Record");
			Process myProcess = new Process();
			myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			myProcess.StartInfo.CreateNoWindow = true;
			myProcess.StartInfo.UseShellExecute = false;
			myProcess.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
			string path = "C:\\Users\\Lucas\\Desktop\\ffmpegtest\\ffmpegtest\\Assets\\recordwebcam.bat";
			myProcess.StartInfo.Arguments = "/c" + path;
			myProcess.EnableRaisingEvents = false;
			myProcess.Start();
			myProcess.WaitForExit();
			int ExitCode = myProcess.ExitCode;
			UnityEngine.Debug.Log(ExitCode);
			UnityEngine.Debug.Log("Record fin");
		} catch (Exception e){
			UnityEngine.Debug.Log (e);        
		}
	}

	void Mersh(){
		try {
			UnityEngine.Debug.Log("Mersh");
			Process myProcess = new Process();
			myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			myProcess.StartInfo.CreateNoWindow = true;
			myProcess.StartInfo.UseShellExecute = false;
			myProcess.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
			string path = "C:\\Users\\Lucas\\Desktop\\ffmpegtest\\ffmpegtest\\Assets\\mershvideos.bat";
			myProcess.StartInfo.Arguments = "/c" + path;
			myProcess.EnableRaisingEvents = false;
			myProcess.Start();
			myProcess.WaitForExit();
			int ExitCode = myProcess.ExitCode;
			UnityEngine.Debug.Log(ExitCode);
			UnityEngine.Debug.Log("Mersh fin");
		} catch (Exception e){
			UnityEngine.Debug.Log (e);        
		}
	}
}
