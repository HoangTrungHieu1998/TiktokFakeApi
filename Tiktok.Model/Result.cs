using System;

namespace Tiktok.Model
{
    public class Result
    {

        internal Result(bool succeeded, string error)
        {
            Succeeded = succeeded;
            Error = error;
        }

        internal Result(bool succeeded, object data)
        {
            Succeeded = succeeded;
            Data = data;
        }

        public object Data { get; set; }

        public bool Succeeded { get; set; }

        public string Error { get; set; }

        public static Result Success()
        {
            return new Result(true, string.Empty);
        }

        public static Result Success(object data)
        {
            return new Result(true, data);
        }

        public static Result Success(object data, string messageSuccess)
        {
            var respone = new Result(true, data);
            respone.Error = messageSuccess;

            return respone;
        }

        public static Result Failure(string error = "")
        {
            return new Result(false, error);
        }

        public static Result Failure(object data)
        {
            return new Result(false, data);
        }

        public static Result Failure(object data, string messageError)
        {
            var respone = new Result(false, data);
            respone.Error = messageError;

            return respone;
        }

    }
}
