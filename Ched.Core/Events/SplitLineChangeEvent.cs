using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ched.Core.Events
{
    /// <summary>
    /// 修改 SplitLine 事件
    /// </summary>
    [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    [DebuggerDisplay("Tick = {Tick}, Value = {LineNumber, LineStyle}")]
    public class SplitLineChangeEvent : EventBase
    {
        [Newtonsoft.Json.JsonProperty]
        private int lineNumber;
        [Newtonsoft.Json.JsonProperty]
        private int lineStyle;

        /// <summary>
        /// LineNumber 事件设定
        /// </summary>
        public int LineNumber
        {
            get { return lineNumber; }
            set { lineNumber = value; }
        }
        public int LineStyle
        {
            get { return lineStyle; }
            set { lineStyle = value; }
        }
    }
}
