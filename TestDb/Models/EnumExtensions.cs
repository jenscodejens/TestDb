//namespace TestDb.Models
//{
//    // Alternativ till att inte använda Newton men det kommer behövas.
//    public static class EnumHelper
//    {
//        public static string Serialize(FileOwnerEntity value)
//        {
//            return Enum.GetName(typeof(FileOwnerEntity), value)?.ToUpper();
//        }

//        public static FileOwnerEntity Deserialize(string value)
//        {
//            return Enum.Parse<FileOwnerEntity>(value.ToUpper());
//        }
//    }
//}

//// Ändra SammanSlaning.cs till: public string SerializedFileOwnerEntity { get; set; }