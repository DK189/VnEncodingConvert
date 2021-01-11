using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnEncodingConvert
{
    public enum EncodeType
    {
        Unicode,
        UTF8,
        VNI,
        VNU,
    }

    public static class EncodeTypeMapping
    {
        static Dictionary<EncodeType, CharMap> CharMaps { get; }

        static EncodeTypeMapping()
        {
            CharMaps = new Dictionary<EncodeType, CharMap>();

            CharMaps.Add(EncodeType.VNU, new CharMap(new char[] {
                (char) 97, (char) 181, (char) 175, (char) 101, (char) 197, (char) 105, (char) 111, (char) 225, (char) 231, (char) 117, (char) 245, (char) 121, (char) 65, (char) 149, (char) 143, (char) 69, (char) 165, (char) 73, (char) 79, (char) 193, (char) 199, (char) 85, (char) 213, (char) 89, (char) 159, (char) 182, (char) 176, (char) 190, (char) 198, (char) 207, (char) 220, (char) 226, (char) 232, (char) 238, (char) 246, (char) 251, (char) 127, (char) 150, (char) 144, (char) 158, (char) 166, (char) 0, (char) 188, (char) 0, (char) 200, (char) 0, (char) 0, (char) 219, (char) 161, (char) 183, (char) 177, (char) 191, (char) 203, (char) 214, (char) 221, (char) 227, (char) 233, (char) 239, (char) 247, (char) 252, (char) 129, (char) 151, (char) 145, (char) 0, (char) 171, (char) 0, (char) 0, (char) 195, (char) 201, (char) 0, (char) 0, (char) 0, (char) 173, (char) 186, (char) 180, (char) 194, (char) 206, (char) 217, (char) 224, (char) 230, (char) 236, (char) 242, (char) 250, (char) 255, (char) 141, (char) 154, (char) 148, (char) 162, (char) 174, (char) 0, (char) 0, (char) 0, (char) 0, (char) 210, (char) 218, (char) 0, (char) 168, (char) 184, (char) 178, (char) 192, (char) 204, (char) 215, (char) 222, (char) 228, (char) 234, (char) 240, (char) 248, (char) 253, (char) 136, (char) 152, (char) 146, (char) 160, (char) 0, (char) 0, (char) 0, (char) 196, (char) 202, (char) 208, (char) 0, (char) 0, (char) 172, (char) 185, (char) 179, (char) 193, (char) 205, (char) 216, (char) 223, (char) 229, (char) 235, (char) 241, (char) 249, (char) 254, (char) 140, (char) 153, (char) 147, (char) 0, (char) 0, (char) 0, (char) 0, (char) 0, (char) 0, (char) 209, (char) 0, (char) 0, (char) 100, (char) 189, (char) 68, (char) 135
            }));

            CharMaps[EncodeType.Unicode] = new CharMap(new char[] {
                (char) 97, (char) 226, (char) 259, (char) 101, (char) 234, (char) 105, (char) 111, (char) 244, (char) 417, (char) 117, (char) 432, (char) 121, (char) 65, (char) 194, (char) 258, (char) 69, (char) 202, (char) 73, (char) 79, (char) 212, (char) 416, (char) 85, (char) 431, (char) 89, (char) 225, (char) 7845, (char) 7855, (char) 233, (char) 7871, (char) 237, (char) 243, (char) 7889, (char) 7899, (char) 250, (char) 7913, (char) 253, (char) 193, (char) 7844, (char) 7854, (char) 201, (char) 7870, (char) 205, (char) 211, (char) 7888, (char) 7898, (char) 218, (char) 7912, (char) 221, (char) 224, (char) 7847, (char) 7857, (char) 232, (char) 7873, (char) 236, (char) 242, (char) 7891, (char) 7901, (char) 249, (char) 7915, (char) 7923, (char) 192, (char) 7846, (char) 7856, (char) 200, (char) 7872, (char) 204, (char) 210, (char) 7890, (char) 7900, (char) 217, (char) 7914, (char) 7922, (char) 7841, (char) 7853, (char) 7863, (char) 7865, (char) 7879, (char) 7883, (char) 7885, (char) 7897, (char) 7907, (char) 7909, (char) 7921, (char) 7925, (char) 7840, (char) 7852, (char) 7862, (char) 7864, (char) 7878, (char) 7882, (char) 7884, (char) 7896, (char) 7906, (char) 7908, (char) 7920, (char) 7924, (char) 7843, (char) 7849, (char) 7859, (char) 7867, (char) 7875, (char) 7881, (char) 7887, (char) 7893, (char) 7903, (char) 7911, (char) 7917, (char) 7927, (char) 7842, (char) 7848, (char) 7858, (char) 7866, (char) 7874, (char) 7880, (char) 7886, (char) 7892, (char) 7902, (char) 7910, (char) 7916, (char) 7926, (char) 227, (char) 7851, (char) 7861, (char) 7869, (char) 7877, (char) 297, (char) 245, (char) 7895, (char) 7905, (char) 361, (char) 7919, (char) 7929, (char) 195, (char) 7850, (char) 7860, (char) 7868, (char) 7876, (char) 296, (char) 213, (char) 7894, (char) 7904, (char) 360, (char) 7918, (char) 7928, (char) 100, (char) 273, (char) 68, (char) 272
            });

            ////
            CharMaps[EncodeType.VNI] = new CharMap(new char[] {
                (char) 97, (char) 226, (char) 259, (char) 101, (char) 234, (char) 105, (char) 111, (char) 244, (char) 417, (char) 117, (char) 432, (char) 121, (char) 65, (char) 194, (char) 258, (char) 69, (char) 202, (char) 73, (char) 79, (char) 212, (char) 416, (char) 85, (char) 431, (char) 89, (char) 225, (char) 7845, (char) 7855, (char) 233, (char) 7871, (char) 237, (char) 243, (char) 7889, (char) 7899, (char) 250, (char) 7913, (char) 253, (char) 193, (char) 7844, (char) 7854, (char) 201, (char) 7870, (char) 205, (char) 211, (char) 7888, (char) 7898, (char) 218, (char) 7912, (char) 221, (char) 224, (char) 7847, (char) 7857, (char) 232, (char) 7873, (char) 236, (char) 242, (char) 7891, (char) 7901, (char) 249, (char) 7915, (char) 7923, (char) 192, (char) 7846, (char) 7856, (char) 200, (char) 7872, (char) 204, (char) 210, (char) 7890, (char) 7900, (char) 217, (char) 7914, (char) 7922, (char) 7841, (char) 7853, (char) 7863, (char) 7865, (char) 7879, (char) 7883, (char) 7885, (char) 7897, (char) 7907, (char) 7909, (char) 7921, (char) 7925, (char) 7840, (char) 7852, (char) 7862, (char) 7864, (char) 7878, (char) 7882, (char) 7884, (char) 7896, (char) 7906, (char) 7908, (char) 7920, (char) 7924, (char) 7843, (char) 7849, (char) 7859, (char) 7867, (char) 7875, (char) 7881, (char) 7887, (char) 7893, (char) 7903, (char) 7911, (char) 7917, (char) 7927, (char) 7842, (char) 7848, (char) 7858, (char) 7866, (char) 7874, (char) 7880, (char) 7886, (char) 7892, (char) 7902, (char) 7910, (char) 7916, (char) 7926, (char) 227, (char) 7851, (char) 7861, (char) 7869, (char) 7877, (char) 297, (char) 245, (char) 7895, (char) 7905, (char) 361, (char) 7919, (char) 7929, (char) 195, (char) 7850, (char) 7860, (char) 7868, (char) 7876, (char) 296, (char) 213, (char) 7894, (char) 7904, (char) 360, (char) 7918, (char) 7928, (char) 100, (char) 273, (char) 68, (char) 272
            });
            CharMaps[EncodeType.UTF8] = new CharMap(new string[] {
                "a", "Ã¢", "Ä", "e", "Ãª", "i", "o", "Ã´", "Æ¡", "u", "Æ°", "y", "A", "Ã", "Ä", "E", "Ã", "I", "O", "Ã", "Æ ", "U", "Æ¯", "Y", "Ã¡", "áº¥", "áº¯", "Ã©", "áº¿", "Ã­", "Ã³", "á»", "á»", "Ãº", "á»©", "Ã½", "Ã", "áº¤", "áº®", "Ã", "áº¾", "Ã", "Ã", "á»", "á»", "Ã", "á»¨", "Ã", "Ã ", "áº§", "áº±", "Ã¨", "á»", "Ã¬", "Ã²", "á»", "á»", "Ã¹", "á»«", "á»³", "Ã", "áº¦", "áº°", "Ã", "á»", "Ã", "Ã", "á»", "á»", "Ã", "á»ª", "á»²", "áº¡", "áº­", "áº·", "áº¹", "á»", "á»", "á»", "á»", "á»£", "á»¥", "á»±", "á»µ", "áº ", "áº¬", "áº¶", "áº¸", "á»", "á»", "á»", "á»", "á»¢", "á»¤", "á»°", "á»´", "áº£", "áº©", "áº³", "áº»", "á»", "á»", "á»", "á»", "á»", "á»§", "á»­", "á»·", "áº¢", "áº¨", "áº²", "áºº", "á»", "á»", "á»", "á»", "á»", "á»¦", "á»¬", "á»¶", "Ã£", "áº«", "áºµ", "áº½", "á»" + ((char) 133), "Ä©", "Ãµ", "á»", "á»¡", "Å©", "á»¯", "á»¹", "Ã", "áºª", "áº´", "áº¼", "á»", "Ä¨", "Ã", "á»", "á» ", "Å¨", "á»®", "á»¸", "d", "Ä", "D", "Ä"
            });
        }
        public static CharMap CharMap(this EncodeType EncodeType)
        {
            if (CharMaps.ContainsKey(EncodeType)) return CharMaps[EncodeType];
            throw new Exception("Bảng mã không tồn tại.");
        }
    }
}
