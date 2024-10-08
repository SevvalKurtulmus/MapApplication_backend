﻿namespace MapApplication
{
    public class Response<T>
    {
        public T Value { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; } = string.Empty; // Varsayılan değer verildi
        public int StatusCode { get; set; }

        public static Response<T> SuccessResponse(T value, string message, int statusCode = 200)
        {
            return new Response<T>
            {
                Value = value,
                Succeeded = true,
                Message = message,
                StatusCode = statusCode
            };
        }

        public static Response<T> ErrorResponse(string message, int statusCode = 400)
        {
            return new Response<T>
            {
                Value = default(T),
                Succeeded = false,
                Message = message,
                StatusCode = statusCode
            };
        }
    }
}
