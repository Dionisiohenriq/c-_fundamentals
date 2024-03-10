namespace Hash_Exercice_File_Log.Entities
{
    public class LogRecord
    {
        public LogRecord(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public string UserName { get; set; }
        public DateTime Instant { get; set; }


        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord)) return false;

            LogRecord other = obj as LogRecord;

            return UserName.Equals(other.UserName);
        }
    }
}
