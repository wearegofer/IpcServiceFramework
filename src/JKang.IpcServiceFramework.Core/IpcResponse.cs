using System;
using Newtonsoft.Json;

namespace JKang.IpcServiceFramework
{
    public class IpcResponse
    {
        [JsonConstructor]
        private IpcResponse(bool succeed, object data, string failure)
        {
            Succeed = succeed;
            Data = data;
            Failure = failure;
        }

        public static IpcResponse Fail(string failure)
        {
            return new IpcResponse(false, null, failure);
        }

        public static IpcResponse Fail(string failure, Exception exception)
        {
            return new IpcResponse(false, null, failure) { Exception = exception };
        }

        public static IpcResponse Success(object data)
        {
            return new IpcResponse(true, data, null);
        }

        public bool Succeed { get; }

        public object Data { get; }

        public string Failure { get; }

        public Exception Exception { get; set; }
    }
}
