
namespace SHVFS_P101_GD08_Jerry
{
    public struct Jerry
    {
        public float X;
        public float Y;
        public float Z;
        public Jerry(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
    public class Tom
    {
        public Jerry pos;
        public string name;

        public Tom(string name, Jerry pos)
        {
            this.pos = pos;
            this.name = name;
        }

        public bool CheckPosition(Tom go)
        {
            if (go.pos.X == pos.X && go.pos.Y == pos.Y && go.pos.Z == pos.Z)
            {
                return true;
            }
            return false;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Tom[] go = new Tom[5];
            go[0] = new Tom("0", new Jerry(0, 20, 60));
            go[1] = new Tom("1", new Jerry(10, 20, 60));
            go[2] = new Tom("2", new Jerry(20, 20, 60));
            go[3] = new Tom("3", new Jerry(0, 20, 60));
            go[4] = new Tom("4", new Jerry(100, 20, 60));
            for (int i = 0; i < go.Length - 1; i++)
            {
                for (int j = i + 1; j < go.Length; j++)
                {
                    if (go[i].CheckPosition(go[j]))
                    {
                        Console.WriteLine($"{go[i].name} and {go[j].name} have the same position");
                    }
                }
            }
        }

    }

}

