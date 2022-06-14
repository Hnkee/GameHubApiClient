using System;
using System.IO.MemoryMappedFiles;

namespace GameHubApiClient
{
	public class GameHubSharedMemoryInput
	{
		private bool _enabled;
		private MemoryMappedFile _dataMemoryMappedFile;
		private MemoryMappedViewAccessor _dataMemoryMappedViewAccessor;

		public string InputInfo => "Shared mem";

		public bool Enabled
		{
			get { return _enabled; }
			set { _enabled = value; }
		}

		public void Write(float yawDegrees, float pitchDegrees, float rollDegrees, float xMillimeter, float yMillimeter, float zMillimeter)
		{
			
		}

		protected void InitializeSharedMemory(string dataFileName, string infoFileName)
		{
			//_dataMemoryMappedFile = MemoryMappedFile.CreateOrOpen(dataFileName, Marshal.SizeOf(typeof(SharedMemoryExtendedViewData)));
			//_dataMemoryMappedViewAccessor = _dataMemoryMappedFile.CreateViewAccessor();

			//_extendedViewData = default;
			//_dataMemoryMappedViewAccessor.Write(0, ref _extendedViewData);

			//_infoMemoryMappedFile = MemoryMappedFile.CreateOrOpen(infoFileName, Marshal.SizeOf(typeof(SharedMemoryInfo)));
			//_infoMemoryMappedViewAccessor = _infoMemoryMappedFile.CreateViewAccessor();

			//_info = default;
			//_infoMemoryMappedViewAccessor.Write(0, ref _info);
		}
		
	}

}
