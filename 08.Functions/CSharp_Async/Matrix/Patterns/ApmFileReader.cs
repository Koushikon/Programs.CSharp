using System.Text;

namespace Matrix.Patterns;

public class ApmFileReader
{
	private byte[]? _buffer;
	private const int InputReportLength = 1024;
	private FileStream? _fileStream;
	private string fileData = string.Empty;

	public void BeginReadAsync(string filePath)
	{
		_buffer = new byte[InputReportLength];
		_fileStream = File.OpenRead(filePath);
		_fileStream.BeginRead(_buffer, 0, InputReportLength, ReadCallbackAsync, _buffer);
	}

	public void ReadCallbackAsync(IAsyncResult iResult)
	{
		// Long-term operation
		_fileStream?.EndRead(iResult);
		var buffer = iResult.AsyncState as byte[] ?? new byte[] { };
		fileData = Encoding.UTF8.GetString(buffer);
	}

	public string GetData()
	{
		return fileData;
	}
}
