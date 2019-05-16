using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace GridDemo
{
  public static class FileUtil
    {
        public static Task SaveAs(this IJSRuntime js, string filename, byte[] data)
            => js.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
    }
}
