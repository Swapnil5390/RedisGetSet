using StackExchange.Redis;


namespace RedisGetSet
{
    internal class Program
    {
        public static string redisServer = "localhost";
        static void Main(string[] args)
        {
            //1.Identity redis server URL
            //2. Imports stack exchange libary for redis connectivity using c#
            //3.Create  ConnectionMultiplexer object for 
            ConnectionMultiplexer conObject = ConnectionMultiplexer.Connect(redisServer);

            IDatabase db = conObject.GetDatabase();

            db.StringSet("Gender", "Male");
            db.StringGet("Gender");

            Console.WriteLine(db.StringGet("Gender"));
            Console.WriteLine("All the Git are changed");
        }
    }
}
