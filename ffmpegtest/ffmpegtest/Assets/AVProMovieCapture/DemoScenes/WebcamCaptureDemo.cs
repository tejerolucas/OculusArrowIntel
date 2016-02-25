using UnityEngine;
using System.Collections;

public class WebcamCaptureDemo : MonoBehaviour 
{
	public AVProMovieCaptureFromTexture _movieCapture;
	public GUISkin _skin;
	private WebCamTexture _texture;
	private int _webcamIndex = -1;
	private GUIContent[] _webcamNames;
	
	void Start() 
	{	
		_webcamNames = new GUIContent[WebCamTexture.devices.Length];
		for (int i = 0 ; i < _webcamNames.Length; i++)
		{
			_webcamNames[i] = new GUIContent(WebCamTexture.devices[i].name);
		}
		
		SelectWebcam(0);
	}

	void Update(){
		if (Input.GetKeyUp (KeyCode.R)) {
			Detener();		
		}
	}

	private void SelectWebcam(int webcamIndex)
	{
		if (webcamIndex < WebCamTexture.devices.Length)
		{
			if (_texture)
			{
				_texture.Stop();
				Destroy(_texture);
				_texture = null;
			}
			_webcamIndex = -1;
			_texture = new WebCamTexture(WebCamTexture.devices[webcamIndex].name, 1280, 720, 30);
			//GetComponent<Renderer>().material.mainTexture=_texture;
			_texture.Play();
			if (_texture.isPlaying)
			{
				_webcamIndex = webcamIndex;
				if (_movieCapture)
				{
					// WebCamTexture actually uses a power of 2 texture so we need to only grab a region of it
					float p2Width = Mathf.NextPowerOfTwo(_texture.width);
					float p2Height = Mathf.NextPowerOfTwo(_texture.height);
					
					_movieCapture.SetSourceTextureRegion(_texture, new Rect(0, 0, 1, 1));
					_movieCapture._forceAudioDeviceIndex=1;
				}
			}
		}
	}
	
	void OnDestroy()
	{
		if (_texture)
		{
			_texture.Stop();
			Destroy(_texture);
			_texture = null;
		}
	}

	public void Capturar(){
		_movieCapture.StartCapture ();
	}

	public void Detener(){
		Debug.Log ("detener");
		_movieCapture.StopCapture ();
		Application.LoadLevel ("Player");
	}
}
