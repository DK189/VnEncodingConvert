using System;

namespace VnEncodingConvert
{
    public class Converter
    {
        private EncodeType baseEncodeType;
        private CharMap myMap;

        public static Converter VNU { get; }
        public static Converter VNI { get; }
        public static Converter Unicode { get; }
        public static Converter UTF8 { get; }

        static Converter()
        {
            VNU = new Converter(EncodeType.VNU);
            VNI = new Converter(EncodeType.VNI);
            UTF8 = new Converter(EncodeType.UTF8);
            Unicode = new Converter(EncodeType.Unicode);
        }

        private Converter(EncodeType baseEncodeType)
        {
            this.baseEncodeType = baseEncodeType;
            this.myMap = baseEncodeType.CharMap();
        }

        public Func<EncodeType, Func<string, string>> FromTo(EncodeType fromEncodeType)
        {
            var fromMap = fromEncodeType.CharMap();
            return (toEncodeType) =>
            {
                var toMap = toEncodeType.CharMap();
                return (string text) =>
                {
                    text = DecodeInternal(text, fromMap);
                    text = EncodeInternal(text, toMap);
                    return text;
                };
            };
        }

        public string ConvertTo(EncodeType toEncodeType, string text)
        {
            var toMap = toEncodeType.CharMap();

            text = DecodeInternal(text, myMap);
            text = EncodeInternal(text, toMap);
            return text;
        }

        public string ConvertFrom(EncodeType fromEncodeType, string text)
        {
            var fromMap = fromEncodeType.CharMap();

            text = DecodeInternal(text, fromMap);
            text = EncodeInternal(text, myMap);
            return text;
        }

        private static string DecodeInternal(string text, CharMap map)
        {
            foreach (var item in map)
            {
                text = text.Replace($"{item.Value}", $"<!{item.Index}!>");
            }
            return text;
        }

        private static string EncodeInternal(string text, CharMap map)
        {
            foreach (var item in map)
            {
                text = text.Replace($"<!{item.Index}!>", $"{item.Value}");
            }
            return text;
        }

        public static Converter Base(EncodeType fromEncodeType)
        {
            return new Converter(fromEncodeType);
        }
    }
}
