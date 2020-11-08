using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BESTEM_20.Data
{
    public class FileSave : IFileSave
    {
        private IJSRuntime _oIJSRuntime { get; }
        public FileSave(IJSRuntime oIJSRuntime)
        {
            _oIJSRuntime = oIJSRuntime;
        }
        public async Task SaveAs(string fileName, string data, string type = "text/plain;charset=utf-8")
        {
            await _oIJSRuntime.InvokeVoidAsync("BESTEM-20.saveAs", fileName, data, type);
        }
    }
}
